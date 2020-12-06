using System.Linq;
using MedelLibrary.Services;
using MedelLibrary.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace MedelLibrary.Controllers
{
    public class SearchController : Controller
    {
        private readonly ILibraryAsset _asset;

        public SearchController(ILibraryAsset asset)
        {
            this._asset = asset;
        }

        public IActionResult Results(string query)
        {
            var results = this._asset.GetAssetsByTitle(query).Select(result => new AssetVM(){
                Id = result.Id,
                Title = result.Title,
                Year = result.Year,
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

            var model = new AssetCatalogVM()
            {
                Assets = results
            };

            return View(model);
        }
    }
}