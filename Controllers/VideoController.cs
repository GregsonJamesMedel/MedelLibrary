using Microsoft.AspNetCore.Mvc;

namespace MedelLibrary.Controllers
{
    public class VideoController : Controller
    {
        [HttpGet]
        public IActionResult AddVideo() => View();
    
    }
}
