using Microsoft.AspNetCore.Mvc;

namespace MedelLibrary.Controllers
{
    public class BookController : Controller
    {
        [HttpGet]
        public IActionResult Categories() => View();

        public IActionResult NewCategory() => View();
    
    }
}
