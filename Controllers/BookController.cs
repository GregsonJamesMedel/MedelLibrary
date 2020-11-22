using Microsoft.AspNetCore.Mvc;
using MedelLibrary.ViewModels;
using MedelLibrary.Services;
using MedelLibrary.Models;

namespace MedelLibrary.Controllers
{
    public class BookController : Controller
    {
        private readonly ICategory _category;

        public BookController(ICategory category)
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
        public IActionResult AddCategory() => View();

        [HttpPost]
        public IActionResult AddCategory(AddCategoryVM model)
        {
            if (ModelState.IsValid)
            {
                var category = new Category() { Name = model.Name };
                this._category.AddCategory(category);
                return RedirectToAction("Categories");
            }
            else
            {
                return View(model);
            }

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
