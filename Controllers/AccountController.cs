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

        public AccountController(UserManager<Patron> userManager,
                                SignInManager<Patron> signInManager,
                                ITransaction transactions,
                                ILibraryAsset libraryAssets)
        {
            this._userManager = userManager;
            this._signInManager = signInManager;
            this._transactions = transactions;
            this._libraryAssets = libraryAssets;
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
        public IActionResult Patrons()
        {
            var model = this._userManager.Users.Select(result => new PatronsVM()
            {
                Id = result.Id,
                Email = result.Email,
                PersonalDetailsVM = new PersonalDetailsVM()
                {
                    Id = result.PersonalDetails.Id,
                    Firstname = result.PersonalDetails.Firstname,
                    Middlename = result.PersonalDetails.Middlename,
                    Lastname = result.PersonalDetails.Lastname,
                    Address = result.PersonalDetails.Address,
                    ImageUrl = result.PersonalDetails.ImageUrl
                }
            });

            return View(model);
        }

        public IActionResult Profile(string id)
        {
            var model = this._userManager.Users.Select(res => new ProfileVM()
            {
                Id = res.Id,
                Firstname = res.PersonalDetails.Firstname,
                Middlename = res.PersonalDetails.Middlename,
                Lastname = res.PersonalDetails.Lastname,
                Gender = res.PersonalDetails.Gender,
                Birthday = res.PersonalDetails.Birthday,
                Address = res.PersonalDetails.Address,
                ImageUrl = res.PersonalDetails.ImageUrl,
                Email = res.Email,
                CurrentFees = res.LibraryCard.Fees,
                ContactNumber = res.PhoneNumber,
                LibraryCardId = res.LibraryCard.Id
            }).FirstOrDefault(p => p.Id == id);

            model.Checkouts = this._transactions
            .GetAllCheckoutHistoryByLibraryCardId(model.LibraryCardId).Select(res => new CheckoutHistoryVM()
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

        public IActionResult Settings(string Id)
        {
            return View();
        }

    }
}
