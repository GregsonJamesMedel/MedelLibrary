using System.Linq;
using System.Threading.Tasks;
using MedelLibrary.Services;
using MedelLibrary.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace MedelLibrary.Controllers
{
    public class PatronsController : Controller
    {
        private readonly IPatron _patronService;
        private readonly RoleManager<IdentityRole> _roleManager;

        public PatronsController(IPatron patronService,
                                RoleManager<IdentityRole> roleManager)
        {
            _patronService = patronService;
            _roleManager = roleManager;
        }

        [HttpGet]
        public IActionResult PatronsList()
        {
            var model = this._patronService.GetAllPatrons()
                .Select(res => new PatronModel()
                {
                    Id = res.Id,
                    Firstname = res.PersonalDetails.Firstname,
                    Lastname = res.PersonalDetails.Lastname,
                    Email = res.Email,
                    Address = res.PersonalDetails.Address,
                    ImageUrl = res.PersonalDetails.ImageUrl
                });

            return View(model);
        }

        [HttpGet]
        public IActionResult Roles()
        {
            var model = new PatronsRolesVM()
            {
                Patrons = this._patronService.GetAllPatrons(),
                Roles = this._roleManager.Roles
            };

            return View(model);
        }

    }
}