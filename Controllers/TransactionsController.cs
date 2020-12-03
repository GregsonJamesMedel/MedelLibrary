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
        public IActionResult CheckOut(int id)
        {
            var model = BuildCheckVM(id);

            if (model == null)
                return RedirectToAction("NotFound", "Error");

            return View(model);
        }

        [HttpPost]
        public IActionResult CheckOut(CheckoutVM model)
        {
            model.Patrons = GetPatronsWithLibraryCard();

            if (model.LibraryCardId == 0)
                ModelState.AddModelError("", "Please select a Patron");

            if (ModelState.IsValid)
            {
                var result = this._transactions.AddCheckout(model.AssetId, model.LibraryCardId);

                if (result)
                    return RedirectToAction("Details", "Asset", new { id = model.AssetId });

            }

            return View(model);
        }

        [HttpPost]
        public IActionResult CheckIn(int id)
        {
            var recentCheckOut = this._transactions.GetRecentCheckOut(id);
            this._transactions.AddCheckIn(recentCheckOut.LibraryAsset.Id,recentCheckOut.LibraryCard.Id);
            return RedirectToAction("Details", "Asset", new { id = recentCheckOut.LibraryAsset.Id });
        }

        [HttpGet]
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
                    Until = result.Until
                });

            return View(model);
        }

        [HttpPost]
        public IActionResult MarkFound(int id)
        {
            this._libraryAsset.MarkFound(id);
            return RedirectToAction("Details", "Asset", new { id = id });
        }

        [HttpPost]
        public IActionResult MarkLost(int id)
        {
            var res = this._libraryAsset.MarkLost(id);
            return RedirectToAction("Details", "Asset", new { id = id });
        }

        [HttpGet]
        public IActionResult Hold(int id)
        {
            var asset = this._libraryAsset.GetAsset(id);

            if(asset == null)
                return RedirectToAction("NotFound","Error");

            var model = new HoldVM()
            {
                AssetId = asset.Id,
                Title = asset.Title,
                AuthorOrDirector = this._libraryAsset.GetAuthorOrDirector(asset.Id),
                AssetCover = asset.ImageUrl,
                Patrons = GetPatronsWithLibraryCard()
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult PlaceHold(HoldVM model)
        {
            var result = this._transactions.AddHold(model.AssetId,model.LibraryCardId);

            if(result)
                return RedirectToAction("Details","Asset",new { id = model.AssetId });
            
            return View(model);
        }

        private CheckoutVM BuildCheckVM(int assetId)
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

    }
}