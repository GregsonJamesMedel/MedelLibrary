using System.Linq;
using MedelLibrary.Models;
using MedelLibrary.Services;
using MedelLibrary.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace MedelLibrary.Controllers
{
    public class TransactionsController : Controller
    {
        private readonly ITransaction _transactions;
        private readonly ILibraryAsset _libraryAsset;
        private readonly UserManager<Patron> _userManager;

        public TransactionsController(ITransaction transactions,
                                        ILibraryAsset libraryAsset,
                                        UserManager<Patron> userManager)
        {
            this._transactions = transactions;
            this._libraryAsset = libraryAsset;
            this._userManager = userManager;
        }

        [HttpGet]
        public IActionResult Checkout(int id)
        {
            var asset = this._libraryAsset.GetAsset(id);

            if (asset == null)
                return RedirectToAction("NotFound", "Error");

            var patrons = this._userManager.Users.Select(result => new PatronLibraryCardVM()
            {
                PatronId = result.Id,
                PatronFullname = result.PersonalDetails.Lastname + " " + result.PersonalDetails.Firstname,
                LibraryCardId = result.LibraryCard.Id
            });

            var model = new CheckoutVM()
            {
                AssetId = asset.Id,
                Title = asset.Title,
                AssetCover = asset.ImageUrl,
                Patrons = patrons,
                AuthorOrDirector = this._libraryAsset.GetAuthorOrDirector(asset.Id)
            };

            return View(model);
        }
    }
}