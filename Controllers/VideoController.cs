using MedelLibrary.Models;
using MedelLibrary.Services;
using MedelLibrary.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MedelLibrary.Controllers
{
    [Authorize(Roles = "Administrator,Staff")]
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
            var model = new NewVideoVM() { Categories = this._category.GetAllCategories() };
            return View("SaveVideo", model);
        }

        [HttpPost]
        public IActionResult SaveVideo(NewVideoVM model)
        {
            model.Categories = this._category.GetAllCategories();

            if (ModelState.IsValid)
            {
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
                    Status = "Check out",
                    ImageUrl = "NoCover.png"
                };

                var result = this._asset.AddLibraryAsset(video);

                if (result)
                    return RedirectToAction("AssetCatalog", "Asset");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult EditVideo(int id)
        {
            var video = this._asset.GetAsset(id);

            if (video == null)
                return RedirectToAction("NotFound", "Error");

            var model = new EditVideoVM()
            {
                Id = video.Id,
                Title = video.Title,
                Year = video.Year,
                Cost = video.Cost,
                ImageUrl = video.ImageUrl,
                NumberOfCopies = video.NumberOfCopies,
                Shelf = video.Shelf,
                Director = this._asset.GetAuthorOrDirector(video.Id),
                Condition = video.Condition,
                Status = video.Status,
                Category = video.Category.id,
                Categories = this._category.GetAllCategories()
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult EditVideo(EditVideoVM model)
        {
            model.Categories = this._category.GetAllCategories();

            if (ModelState.IsValid)
            {
                var video = new Video()
                {
                    Id = model.Id,
                    Title = model.Title,
                    Year = model.Year,
                    Cost = model.Cost,
                    ImageUrl = model.ImageUrl,
                    NumberOfCopies = model.NumberOfCopies,
                    Shelf = model.Shelf,
                    Director = model.Director,
                    Condition = model.Condition,
                    Status = model.Status,
                    Category = this._category.GetCategoryById(model.Category)
                };

                var result = this._asset.UpdateAsset(video);

                if (result)
                    return RedirectToAction("Details", "Asset", new { id = video.Id });
            }
            return View(model);
        }

    }
}
