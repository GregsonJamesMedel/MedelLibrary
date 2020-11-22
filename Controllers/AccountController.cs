using Microsoft.AspNetCore.Mvc;

namespace MedelLibrary.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult SignIn() => View();

        public IActionResult SignUp() => View();
    
    }
}
