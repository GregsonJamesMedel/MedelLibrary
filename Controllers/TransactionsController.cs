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
        public IActionResult Checkout(int id)
        {
            var model = BuildCheckoutVM(id);

            if (model == null)
                return RedirectToAction("NotFound", "Error");

            return View(model);
        }

        [HttpPost]
        public IActionResult Checkout(CheckoutVM model)
        {
            model.Patrons = GetPatronsWithLibraryCard();

            if (model.LibraryCardId == 0)
                ModelState.AddModelError("", "Please select a Patron");

            if (ModelState.IsValid)
            {
                var result = this._transactions.AddCheckout(model.AssetId,model.LibraryCardId);

                if (result)
                {
                    this._transactions.UpdateStatus(model.AssetId, "Checked out");
                    return RedirectToAction("AssetCatalog", "Asset");
                }
            }

            return View(model);
        }

        private CheckoutVM BuildCheckoutVM(int assetId)
        {
            var asset = this._libraryAsset.GetAsset(assetId);

            if (asset == null)
                return null;

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

        public IActionResult CheckoutList()
        {
            var model = this._transactions.GetAllCheckouts()
                .Select(result => new CheckoutListVM()
                {
                    CheckoutId = result.Id,
                    AssetTitle = result.LibraryAsset.Title,
                    AuthorOrDirector = this._libraryAsset.GetAuthorOrDirector(result.LibraryAsset.Id),
                    AssetType = this._libraryAsset.GetType(result.LibraryAsset.Id),
                    LibraryCardId = result.LibraryCard.Id,
                    Since = result.Since,
                    Until = result.Untill
                });

            return View(model);
        }
    }
}