using System.Linq;
using MedelLibrary.Services;
using MedelLibrary.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace MedelLibrary.Controllers
{
    public class AssetController : Controller
    {
        private readonly ILibraryAsset _asset;
        private readonly IImage _imageProcessor;
        private readonly ITransaction _transactions;

        public AssetController(ILibraryAsset asset, IImage imageProcessor, ITransaction transactions)
        {
            this._asset = asset;
            this._imageProcessor = imageProcessor;
            this._transactions = transactions;
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var asset = this._asset.GetAsset(id);

            if (asset == null)
                return RedirectToAction("NotFound", "Error");

            var model = new AssetVM()
            {
                Id = asset.Id,
                Title = asset.Title,
                AuthorOrDirector = this._asset.GetAuthorOrDirector(asset.Id),
                Year = asset.Year,
                Status = asset.Status,
                Cost = asset.Cost,
                ImageUrl = asset.ImageUrl,
                NumberOfCopies = asset.NumberOfCopies,
                Shelf = asset.Shelf,
                Condition = asset.Condition,
                Category = asset.Category,
                ISBN = this._asset.GetISBN(id),
                Type = this._asset.GetType(id),
                Holds = this._transactions.GetAssetHolds(asset.Id),
                CheckoutHistories = this._transactions.GetCheckoutHistoriesByAssetId(asset.Id)
            };

            return View(model);
        }

        [HttpGet]
        public IActionResult AssetCatalog()
        {
            var assets = this._asset.GetAllAssets();

            var assetList = assets.Select(result => new AssetVM()
            {
                Id = result.Id,
                Title = result.Title,
                Year = result.Year,
                Status = result.Status,
                Cost = result.Cost,
                ImageUrl = result.ImageUrl,
                NumberOfCopies = result.NumberOfCopies,
                Shelf = result.Shelf,
                Condition = result.Condition,
                Category = result.Category,
                ISBN = this._asset.GetISBN(result.Id),
                AuthorOrDirector = this._asset.GetAuthorOrDirector(result.Id),
                Type = this._asset.GetType(result.Id)
            });

            var model = new AssetCatalogVM() { Assets = assetList };

            return View(model);
        }

        [HttpPost]
        public IActionResult DeleteAsset(int id)
        {
            var result = this._asset.DeleteAsset(id);

            if (result)
                return RedirectToAction("AssetCatalog");

            return RedirectToAction("Details", id);
        }

        [HttpGet]
        public IActionResult EditCover(int id)
        {
            var asset = this._asset.GetAsset(id);

            if (asset == null)
                return RedirectToAction("NotFound", "Error");

            var model = new EditCoverVM()
            {
                Id = asset.Id,
                Title = asset.Title,
                ImageUrl = asset.ImageUrl,
                AuthorOrDirector = this._asset.GetAuthorOrDirector(asset.Id)
            };

            return View(model);
        }

        public IActionResult EditCover(EditCoverVM model)
        {
            if (ModelState.IsValid)
            {
                var asset = this._asset.GetAsset(model.Id);

                var saveImage = this._imageProcessor.SaveImage(model.Image);

                if (saveImage != null)
                {
                    asset.ImageUrl = saveImage;
                    var result = this._asset.UpdateAsset(asset);

                    if (result)
                        return RedirectToAction("Details", new { id = asset.Id });
                }
            }

            return View(model);
        }

    }
}
