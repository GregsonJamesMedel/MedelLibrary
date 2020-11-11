using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MedelLibrary.Models;

namespace MedelLibrary.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult SignIn() => View();

        public IActionResult SignUp() => View();
    
    }
}
