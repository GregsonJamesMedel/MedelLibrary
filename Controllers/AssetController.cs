using Microsoft.AspNetCore.Mvc;

namespace MedelLibrary.Controllers
{
    public class AssetController : Controller
    {
        [HttpGet]
        public IActionResult AssetCatalog() => View();
    
    }
}
