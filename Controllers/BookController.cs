using MedelLibrary.Models;
using MedelLibrary.Services;
using MedelLibrary.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace MedelLibrary.Controllers
{
    public class BookController : Controller
    {
        private readonly ICategory _category;
        private readonly ILibraryAsset _libraryAsset;

        public BookController(ICategory category, ILibraryAsset libraryAsset)
        {
            this._category = category;
            this._libraryAsset = libraryAsset;
        }
        
        [HttpGet]
        public IActionResult Books() 
        {

            return View(this._libraryAsset.GetAllAssets());
        } 

        [HttpGet]
        public IActionResult AddBook()
        {
            var saveBookVM = new NewBookVM(){ Categories = this._category.GetAllCategories() };
        
            return View("SaveBook",saveBookVM);
        }

        [HttpPost]
        public IActionResult SaveBook(NewBookVM model)
        {
            model.Categories = this._category.GetAllCategories();

            if(!ModelState.IsValid)
                return View(model);

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
                Category = category,
                Condition = "New",
                Status = "Checked in"
            };

            var result = this._libraryAsset.AddLibraryAsset(book);

            if(result)
                return RedirectToAction("Books");

            return View(model);
        }
    
    }
}
