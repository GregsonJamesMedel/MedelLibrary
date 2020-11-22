using Microsoft.AspNetCore.Mvc;

namespace MedelLibrary.Controllers
{
    public class BookController : Controller
    {
        [HttpGet]
        public IActionResult Books() => View();
    
    }
}
