using MedelLibrary.Models;
using MedelLibrary.Services;
using MedelLibrary.ViewModels;
using Microsoft.AspNetCore.Mvc;

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
        public IActionResult Books() => View();

        [HttpGet]
        public IActionResult AddBook()
        {
            var saveBookVM = new NewBookVM(){ Categories = this._category.GetAllCategories() };
        
            return View("SaveBook",saveBookVM);
        }

        [HttpPost]
        public IActionResult SaveBook(NewBookVM model)
        {
            var category = this._category.GetCategoryById(model.Category);

            var book = new Book()
            {
                ISBN = model.ISBN,
                Title = model.Title,
                Author = model.Author,
                Year = model.Year,
                Cost = model.Cost,
                NumberOfCopies = model.NumberOfCopies,
                Shelf = model.Shelf,
                Category = category
            };

            model.Categories = this._category.GetAllCategories();
            return View("test",model);
        }
    
    }
}
