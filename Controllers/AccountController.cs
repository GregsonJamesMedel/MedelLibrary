using System.Threading.Tasks;
using MedelLibrary.Models;
using MedelLibrary.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
namespace MedelLibrary.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<Patron> _userManager;
        private readonly SignInManager<Patron> _signInManager;

        public AccountController(UserManager<Patron> userManager, SignInManager<Patron> signInManager)
        {
            this._userManager = userManager;
            this._signInManager = signInManager;
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
                var patron = new Patron()
                {
                    UserName = model.Email,
                    Firstname = model.Firstname,
                    Lastname = model.Lastname,
                    Email = model.Email,
                    Address = model.Address,
                    PhoneNumber = model.ContactNumber
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
            return RedirectToAction("AssetCatalog","Asset");
        }
    }
}
