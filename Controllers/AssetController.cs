using Microsoft.AspNetCore.Mvc;
using MedelLibrary.ViewModels;
using MedelLibrary.Services;
using MedelLibrary.Models;

namespace MedelLibrary.Controllers
{
    public class AssetController : Controller
    {
        private readonly ICategory _category;

        public AssetController(ICategory category)
        {
            this._category = category;
        }

        [HttpGet]
        public IActionResult Categories()
        {
            var categories = this._category.GetAllCategories();
            return View(categories);
        }

        [HttpGet]
        public IActionResult AddCategory()
        {
            ViewBag.Title = "Add Category";
            return View("SaveCategory");
        }


        [HttpPost]
        public IActionResult SaveCategory(SaveCategoryVM model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var category = new Category();
            var result = false;

            if (model.id != null || model.id == 0)
            {
                category.Name = model.Name;
                result = this._category.UpdateCategory((int)model.id, category);
            }
            else
            {
                category.Name = model.Name;
                result = this._category.AddCategory(category);
            }

            if(result)
                return RedirectToAction("Categories");

            return View(model);
        }

        [HttpGet]
        public IActionResult EditCategory(int id)
        {
            ViewBag.Title = "Edit Category";

            var categoryToEdit = this._category.GetCategoryById(id);
            var saveCategoryVM = new SaveCategoryVM() { id = categoryToEdit.id, Name = categoryToEdit.Name };

            return View("SaveCategory", saveCategoryVM);
        }

        [HttpPost]
        public IActionResult DeleteCategory(int id)
        {
            this._category.DeleteCategory(id);
            return RedirectToAction("Categories");
        }

        public IActionResult Books() => View();

    }
}
