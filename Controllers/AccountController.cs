using System;
using System.Linq;
using System.Threading.Tasks;
using MedelLibrary.Models;
using MedelLibrary.Services;
using MedelLibrary.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
namespace MedelLibrary.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<Patron> _userManager;
        private readonly SignInManager<Patron> _signInManager;
        private readonly ITransaction _transactions;
        private readonly ILibraryAsset _libraryAssets;
        private readonly IPatron _patronService;

        public AccountController(UserManager<Patron> userManager,
                                SignInManager<Patron> signInManager,
                                ITransaction transactions,
                                ILibraryAsset libraryAssets,
                                IPatron patronService)
        {
            this._userManager = userManager;
            this._signInManager = signInManager;
            this._transactions = transactions;
            this._libraryAssets = libraryAssets;
            this._patronService = patronService;
        }

        [HttpGet]
        public IActionResult SignIn() => View();

        [HttpGet]
        public IActionResult SignUp() => View();

        [HttpPost]
        public async Task<IActionResult> SignUp(SignUpVM model)
        {
            if (ModelState.IsValid)
            {
                var pDetails = new PersonalDetails()
                {
                    Firstname = model.Firstname,
                    Lastname = model.Lastname,
                    Address = model.Address
                };

                var patron = new Patron()
                {
                    UserName = model.Email,
                    Email = model.Email,
                    PhoneNumber = model.ContactNumber,
                    LibraryCard = this._transactions.CreateLibraryCard(),
                    PersonalDetails = pDetails
                };

                var result = await this._userManager.CreateAsync(patron, model.Password);

                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(patron, isPersistent: false);
                    return RedirectToAction("AssetCatalog", "Asset");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> SignIn(SignInVM model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var result =
                await this._signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false);

                if (result.Succeeded)
                {
                    if (!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
                    {
                        return Redirect(returnUrl);
                    }

                    return RedirectToAction("AssetCatalog", "Asset");
                }
                ModelState.AddModelError(string.Empty, "Invalid Login Attempt");
            }
            return View(model);
        }

        public async Task<IActionResult> SignOut()
        {
            await this._signInManager.SignOutAsync();
            return RedirectToAction("AssetCatalog", "Asset");
        }

        [HttpGet]
        public IActionResult Patrons() => View(this._patronService.GetAllPatrons());

        public IActionResult Profile(string id)
        {
            var patron = this._patronService.GetPatronById(id);

            var model = new ProfileVM(){
                Id = patron.Id,
                Firstname = patron.Firstname,
                Middlename = patron.Middlename,
                Lastname = patron.Lastname,
                Gender = patron.Gender,
                Birthday = patron.Birthday,
                Address = patron.Address,
                ImageUrl = patron.ImageUrl,
                Email = patron.Email,
                ContactNumber = patron.PhoneNumber,
                CurrentFees = this._transactions.GetLibraryCardById(patron.LibraryCardId).Fees,
            };

            model.Checkouts = this._transactions
            .GetAllCheckoutHistoryByLibraryCardId(patron.LibraryCardId).Select(res => new CheckoutHistoryVM()
            {
                Id = res.Id,
                AssetId = res.LibraryAsset.Id.ToString(),
                Title = res.LibraryAsset.Title,
                AuthorOrDirector = this._libraryAssets.GetAuthorOrDirector(res.LibraryAsset.Id),
                Type = this._libraryAssets.GetType(res.LibraryAsset.Id),
                LibraryCardId = res.LibraryCard.Id,
                Checkin = res.Checkin,
                Checkout = res.Checkout
            });

            return View(model);
        }

        public IActionResult Settings(string id)
        {
            return View();
        }

    }
}
