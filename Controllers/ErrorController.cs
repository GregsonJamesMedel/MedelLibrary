using Microsoft.AspNetCore.Mvc;

namespace MedelLibrary.Controllers
{
    public class ErrorController : Controller
    {
        [Route("Error")]
        public new IActionResult NotFound()
        {
            return View();
        }
    }
}