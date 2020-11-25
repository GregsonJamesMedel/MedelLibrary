using Microsoft.AspNetCore.Mvc;
using MedelLibrary.ViewModels;
using MedelLibrary.Services;
using MedelLibrary.Models;
using MedelLibrary.Data;
using Microsoft.AspNetCore.Authorization;

namespace MedelLibrary.Controllers
{
    [Authorize]
    public class CategoryController : Controller
    {
        private readonly ICategory _category;

        public CategoryController(ICategory category)
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

            var category = new Category();
            var result = false;

            if (model.id != null || model.id == 0)
            {
                if (!ModelState.IsValid)
                {
                    ViewBag.Title = "Edit Category";
                    return View(model);
                }

                category.Name = model.Name;
                result = this._category.UpdateCategory((int)model.id, category);
            }
            else
            {
                if (!ModelState.IsValid)
                {
                    ViewBag.Title = "Add Category";
                    return View(model);
                }

                category.Name = model.Name;
                result = this._category.AddCategory(category);
            }

            if (result)
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

    }
}
