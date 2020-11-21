using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MedelLibrary.Models;

namespace MedelLibrary.Controllers
{
    public class BookController : Controller
    {
        [HttpGet]
        public IActionResult Categories() => View();

        public IActionResult NewCategory() => View();
    
    }
}
