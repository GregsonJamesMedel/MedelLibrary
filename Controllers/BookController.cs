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
        public IActionResult Books() => View(this._libraryAsset.GetAllBooks());

        [HttpGet]
        public IActionResult AddBook()
        {
            var saveBookVM = new NewBookVM() { Categories = this._category.GetAllCategories() };

            return View("SaveBook", saveBookVM);
        }

        [HttpPost]
        public IActionResult SaveBook(NewBookVM model)
        {
            model.Categories = this._category.GetAllCategories();

            if (!ModelState.IsValid)
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

            if (result)
                return RedirectToAction("AssetCatalog", "Asset");

            return View(model);
        }

        [HttpGet]
        public IActionResult EditBook(int id)
        {
            var book = this._libraryAsset.GetAsset(id);

            //Write error if book didn't exists

            var model = new EditBookVM()
            {
                Id = book.Id,
                Title = book.Title,
                Year = book.Year,
                Status = book.Status,
                Cost = book.Cost,
                ImageUrl = book.ImageUrl,
                NumberOfCopies = book.NumberOfCopies,
                Shelf = book.Shelf,
                Condition = book.Condition,
                ISBN = this._libraryAsset.GetISBN(book.Id),
                Author = this._libraryAsset.GetAuthorOrDirector(book.Id),
                Category = book.Category,
                Categories = this._category.GetAllCategories()
            };

            return View(model);
        }


        public IActionResult EditBook(EditBookVM model)
        {
            model.Categories = this._category.GetAllCategories();

            if(!ModelState.IsValid)
                return View(model);

            return View(model);
        }
    }
}
