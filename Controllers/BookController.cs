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
            model.Categories = this._category.GetAllCategories();
            return View("test",model);
        }
    
    }
}
