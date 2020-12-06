using MedelLibrary.Services;
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
            var model = this._asset.GetAssetsByTitle(query);
            return View(model);
        }
    }
}