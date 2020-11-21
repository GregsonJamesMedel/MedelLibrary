using Microsoft.AspNetCore.Mvc;
using MedelLibrary.ViewModels;

namespace MedelLibrary.Controllers
{
    public class BookController : Controller
    {
        [HttpGet]
        public IActionResult Categories() => View();

        public IActionResult NewCategory() => View();

        // public IActionResult NewCategory(NewCategoryVM model)
        // {

        // }

    }
}
