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
        private readonly IPersonalDetails _personalDetails;
        private readonly ITransaction _transactions;

        public AccountController(UserManager<Patron> userManager,
                                SignInManager<Patron> signInManager,
                                IPersonalDetails personalDetails,
                                ITransaction transactions)
        {
            this._userManager = userManager;
            this._signInManager = signInManager;
            this._personalDetails = personalDetails;
            this._transactions = transactions;
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
                    PersonalDetails = this._personalDetails.AddPersonalDetails(pDetails)
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
            return View();
        }

    }
}
