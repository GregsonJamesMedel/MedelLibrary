using MedelLibrary.Services;
using MedelLibrary.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace MedelLibrary.Controllers
{
    public class TransactionsController : Controller
    {
        private readonly ITransaction _transactions;
        private readonly ILibraryAsset _libraryAsset;

        public TransactionsController(ITransaction transactions,
                                        ILibraryAsset libraryAsset)
        {
            this._transactions = transactions;
            this._libraryAsset = libraryAsset;
        }

        [HttpGet]
        public IActionResult Checkout(int id)
        {
            var asset = this._libraryAsset.GetAsset(id);

            if (asset == null)
                return RedirectToAction("NotFound", "Error");

            var model = new CheckoutVM()
            {
                AssetId = asset.Id
            };

            return View(model);
        }
    }
}