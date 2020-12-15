using MedelLibrary.Models;
using MedelLibrary.Services;
using MedelLibrary.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MedelLibrary.Controllers
{
    [Authorize(Roles = "Administrator,Staff")]
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

            if (ModelState.IsValid)
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
                    Category = category,
                    Condition = "New",
                    Status = "Available",
                    ImageUrl = "NoCover.png"
                };

                var result = this._libraryAsset.AddLibraryAsset(book);

                if (result)
                    return RedirectToAction("AssetCatalog", "Asset");

            }

            return View(model);
        }

        [HttpGet]
        public IActionResult EditBook(int id)
        {
            var book = this._libraryAsset.GetAsset(id);

            if (book == null)
                return RedirectToAction("NotFound", "Error");

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
                Category = this._category.GetCategoryById(book.Category.id).id,
                Categories = this._category.GetAllCategories()
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult EditBook(EditBookVM model)
        {
            model.Categories = this._category.GetAllCategories();

            if (ModelState.IsValid)
            {
                var category = this._category.GetCategoryById(model.Category);

                var book = new Book()
                {
                    Id = model.Id,
                    Title = model.Title,
                    Year = model.Year,
                    Status = model.Status,
                    Cost = model.Cost,
                    ImageUrl = model.ImageUrl,
                    NumberOfCopies = model.NumberOfCopies,
                    Shelf = model.Shelf,
                    Condition = model.Condition,
                    ISBN = model.ISBN,
                    Author = model.Author,
                    Category = category
                };

                var result = this._libraryAsset.UpdateAsset(book);

                if (result)
                    return RedirectToAction("AssetCatalog", "Asset");
            }

            return View(model);
        }
    }
}
