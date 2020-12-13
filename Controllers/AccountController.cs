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
        private readonly SignInManager<Patron> _signInManager;
        private readonly ITransaction _transactions;
        private readonly ILibraryAsset _libraryAssets;
        private readonly IPatron _patronService;
        private readonly IImage _imageProcessor;

        public AccountController(SignInManager<Patron> signInManager,
                                ITransaction transactions,
                                ILibraryAsset libraryAssets,
                                IPatron patronService,
                                IImage imageProcessor)
        {
            this._signInManager = signInManager;
            this._transactions = transactions;
            this._libraryAssets = libraryAssets;
            this._patronService = patronService;
            this._imageProcessor = imageProcessor;
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
                var result = this._patronService.SignUp(model);

                if (result != null)
                {
                    await _signInManager.SignInAsync(await result, isPersistent: false);
                    return RedirectToAction("AssetCatalog", "Asset");
                }
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> SignIn(SignInVM model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var result = await this._patronService.SignIn(model);

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
            var model = this._patronService.GetAllPatrons()
            .Select(res => new PatronModel()
            {
                Id = res.Id,
                Firstname = res.PersonalDetails.Firstname,
                Lastname = res.PersonalDetails.Lastname,
                Email = res.Email,
                Address = res.PersonalDetails.Address,
                ImageUrl = res.PersonalDetails.ImageUrl
            });

            return View(model);
        }

        public IActionResult Profile(string id)
        {
            var patron = this._patronService.GetPatronById(id);

            var model = new ProfileVM()
            {
                Id = patron.Id,
                Firstname = patron.PersonalDetails.Firstname,
                Middlename = patron.PersonalDetails.Middlename,
                Lastname = patron.PersonalDetails.Lastname,
                Gender = patron.PersonalDetails.Gender,
                Birthday = patron.PersonalDetails.Birthday,
                Address = patron.PersonalDetails.Address,
                ImageUrl = patron.PersonalDetails.ImageUrl,
                Email = patron.Email,
                ContactNumber = patron.PhoneNumber,
                CurrentFees = patron.LibraryCard.Fees,
            };

            model.Checkouts = this._transactions
            .GetAllCheckoutHistoryByLibraryCardId(patron.LibraryCard.Id).Select(res => new CheckoutHistoryVM()
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

        [HttpGet]
        public IActionResult Settings(string id)
        {
            var patron = this._patronService.GetPatronById(id);

            var pdetails = new SettingsPersonalDetailsVM()
            {
                Id = patron.Id,
                Firstname = patron.PersonalDetails.Firstname,
                Middlename = patron.PersonalDetails.Middlename,
                Lastname = patron.PersonalDetails.Lastname,
                Gender = patron.PersonalDetails.Gender,
                Address = patron.PersonalDetails.Address,
                Birthday = patron.PersonalDetails.Birthday,
                ContactNumber = patron.PhoneNumber
            };

            var model = new SettingsVM()
            {
                PersonalDetails = pdetails,
                ChangePassword = new SettingsChangePasswordVM(){ Id = patron.Id },
                ProfilePhoto = new SettingsProfilePhotoVM()
                { Id = patron.Id, ImagePath = patron.PersonalDetails.ImageUrl }
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult UpdateProfile(SettingsPersonalDetailsVM model)
        {
            Patron patron = this._patronService.GetPatronById(model.Id);

            if (patron == null)
                return RedirectToAction("NotFound", "Error");

            patron.PersonalDetails.Firstname = model.Firstname;
            patron.PersonalDetails.Middlename = model.Middlename;
            patron.PersonalDetails.Lastname = model.Lastname;
            patron.PersonalDetails.Address = model.Address;
            patron.PersonalDetails.Gender = model.Gender;
            patron.PersonalDetails.Birthday = model.Birthday;
            patron.PhoneNumber = model.ContactNumber;

            var result = this._patronService.UpdatePatron(patron);

            if (result)
                return RedirectToAction("Profile", "Account", new { id = patron.Id });

            return View(model);
        }

        [HttpPost]
        public IActionResult UpdatePicture(SettingsProfilePhotoVM model)
        {
            var patron = this._patronService.GetPatronById(model.Id);

            if (patron == null)
                return RedirectToAction("NotFound", "Error");

            patron.PersonalDetails.ImageUrl = this._imageProcessor.SaveImage(model.Image, "ProfilePhotos");

            this._patronService.UpdatePatron(patron);

            return RedirectToAction("Profile", "Account", new { id = patron.Id });
        }

        [HttpPost]
        public async Task<IActionResult> ChangePassword(SettingsChangePasswordVM model)
        {
            var patron = this._patronService.GetPatronById(model.Id);
            
            if(patron == null)
                return RedirectToAction("NotFound", "Error");

            var IsUpdated = this._patronService.ChangePassword(patron,model.CurrentPassword,model.Password);
            
            if( await IsUpdated)
                return RedirectToAction("Profile", "Account", new { id = patron.Id });

            return View(model);
        }

    }
}
