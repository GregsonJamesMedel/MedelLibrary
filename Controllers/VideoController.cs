using MedelLibrary.Models;
using MedelLibrary.Services;
using MedelLibrary.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace MedelLibrary.Controllers
{
    public class VideoController : Controller
    {
        private readonly ICategory _category;
        private readonly ILibraryAsset _asset;

        public VideoController(ICategory category, ILibraryAsset asset)
        {
            this._category = category;
            this._asset = asset;
        }

        [HttpGet]
        public IActionResult AddVideo() 
        {
            var model = new NewVideoVM(){ Categories = this._category.GetAllCategories() };
            return View("SaveVideo",model);
        }

        [HttpPost]
        public IActionResult SaveVideo(NewVideoVM model)
        {
            model.Categories = this._category.GetAllCategories();
            
            if(!ModelState.IsValid)
                return View(model);

            var category = this._category.GetCategoryById(model.Category);

            var video = new Video()
            {
                Title = model.Title,
                Director = model.Director,
                Category = category,
                Shelf = model.Shelf,
                Year = model.Year,
                NumberOfCopies = model.NumberOfCopies,
                Cost = model.Cost,
                Condition = "New",
                Status = "Check out"
            };

            var result = this._asset.AddLibraryAsset(video);
            
            if(result)
                return RedirectToAction("AssetCatalog","Asset");

            return View(model);

        }
    
    }
}
