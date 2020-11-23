using MedelLibrary.Services;
using MedelLibrary.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace MedelLibrary.Controllers
{
    public class VideoController : Controller
    {
        private readonly ICategory _category;

        public VideoController(ICategory category)
        {
            this._category = category;
        }

        [HttpGet]
        public IActionResult AddVideo() 
        {
            var model = new NewVideoVM(){ Categories = this._category.GetAllCategories() };
            return View(model);
        }
    
    }
}
