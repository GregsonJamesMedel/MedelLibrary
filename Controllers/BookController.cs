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
        public IActionResult Categories() => View();

        [HttpGet]
        public IActionResult AddCategory() => View();

        [HttpPost]
        public IActionResult AddCategory(NewCategoryVM model)
        {
            if (ModelState.IsValid)
            {
                var category = new Category() { Name = model.Name };
                this._category.AddCategory(category);
                return RedirectToAction("Categories");
            }

            return View(model);
        }

    }
}
