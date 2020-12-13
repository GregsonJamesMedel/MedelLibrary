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
        private readonly IPatron _patronService;

        public TransactionsController(ITransaction transactions,
                                        ILibraryAsset libraryAsset,
                                        UserManager<Patron> userManager, 
                                        IPatron patronService)
        {
            this._transactions = transactions;
            this._libraryAsset = libraryAsset;
            _patronService = patronService;
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
        public IActionResult CheckOutForHold(int id)
        {
            var hold = this._transactions.GetMostRecentHold(id);
            var result = this._transactions.AddCheckout(hold.LibraryAsset.Id, hold.LibraryCard.Id);

            if (result)
                this._transactions.RemoveHold(hold.Id);

            return RedirectToAction("Details", "Asset", new { id = hold.LibraryAsset.Id });
        }

        [HttpPost]
        public IActionResult CheckIn(int id)
        {
            var recentCheckOut = this._transactions.GetRecentCheckOut(id);
            this._transactions.AddCheckIn(recentCheckOut.LibraryAsset.Id, recentCheckOut.LibraryCard.Id);
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

            if (asset == null)
                return RedirectToAction("NotFound", "Error");

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
            var result = this._transactions.AddHold(model.AssetId, model.LibraryCardId);

            if (result)
                return RedirectToAction("Details", "Asset", new { id = model.AssetId });

            return View(model);
        }
        
        [HttpGet]
        public IActionResult Payments()
        {
            var model = this._patronService.GetAllPatronsWithFees()
                .Select(res => new TransactionsPaymentVM{
                PatronId = res.Id,
                FullName = res.PersonalDetails.Firstname + " " + 
                            res.PersonalDetails.Middlename + " " + 
                            res.PersonalDetails.Lastname,
                CurrentFees = res.LibraryCard.Fees

            });

            return View(model);
        }

        [HttpPost]
        public IActionResult Payments(string Id)
        {
            this._transactions.SettleFees(Id);
            return RedirectToAction("Payments","Transactions");
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
            return this._patronService.GetAllPatrons().Select(result => new PatronLibraryCardVM()
            {
                PatronId = result.Id,
                PatronFullname = result.PersonalDetails.Lastname + " " + result.PersonalDetails.Firstname,
                LibraryCardId = result.LibraryCard.Id
            });
        }



    }
}