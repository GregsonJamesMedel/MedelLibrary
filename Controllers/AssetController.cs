using System.Collections.Generic;
using System.Linq;
using MedelLibrary.Services;
using MedelLibrary.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace MedelLibrary.Controllers
{
    public class AssetController : Controller
    {
        private readonly ILibraryAsset _asset;

        public AssetController(ILibraryAsset asset)
        {
            this._asset = asset;
        }

        [HttpGet]
        public IActionResult AssetCatalog()
        {
            var assets = this._asset.GetAllAssets();

            var assetList = assets.Select(result => new AssetVM(){
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

            var model = new AssetCatalogVM(){ Assets = assetList };

            return View(model);
        }
    
    }
}
