using System;
using System.Collections.Generic;
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
        public IActionResult Checkout(int id) => View(BuildCheckoutVM(id));

        [HttpPost]
        public IActionResult Checkout(CheckoutVM model)
        {
            model.Patrons = GetPatronsWithLibraryCard();

            if (model.LibraryCardId == 0)
            {
                ModelState.AddModelError("", "Please select a Patron");
            }
            
            if(ModelState.IsValid)
            {
                var asset = this._libraryAsset.GetAsset(model.AssetId);
                var libraryCard = this._transactions.GetLibraryCardById(model.LibraryCardId);

                var checkout = new Checkout()
                {
                    LibraryAsset = asset,
                    LibraryCard = libraryCard,
                    Since = DateTime.Now,
                    Untill = DateTime.Now.AddDays(7)
                };

                var result = this._transactions.AddCheckout(checkout);

                if(result)
                {
                    this._transactions.UpdateStatus(asset.Id,"Checked out");
                    return RedirectToAction("AssetCatalog","Asset");
                }
            }

            return View(model);
        }

        private CheckoutVM BuildCheckoutVM(int assetId)
        {
            var asset = this._libraryAsset.GetAsset(assetId);

            if (asset == null)
                RedirectToAction("NotFound", "Error");

            var patrons = GetPatronsWithLibraryCard();

            var model = new CheckoutVM()
            {
                AssetId = asset.Id,
                Title = asset.Title,
                AssetCover = asset.ImageUrl,
                Patrons = patrons,
                AuthorOrDirector = this._libraryAsset.GetAuthorOrDirector(asset.Id)
            };

            return model;
        }

        private IEnumerable<PatronLibraryCardVM> GetPatronsWithLibraryCard()
        {
            return this._userManager.Users.Select(result => new PatronLibraryCardVM()
            {
                PatronId = result.Id,
                PatronFullname = result.PersonalDetails.Lastname + " " + result.PersonalDetails.Firstname,
                LibraryCardId = result.LibraryCard.Id
            });
        }
    }
}