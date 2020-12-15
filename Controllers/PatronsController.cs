using System.Linq;
using System.Threading.Tasks;
using MedelLibrary.Models;
using MedelLibrary.Services;
using MedelLibrary.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace MedelLibrary.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class PatronsController : Controller
    {
        private readonly IPatron _patronService;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<Patron> _userManager;

        public PatronsController(IPatron patronService,
                                RoleManager<IdentityRole> roleManager, 
                                UserManager<Patron> userManager)
        {
            _patronService = patronService;
            _roleManager = roleManager;
            _userManager = userManager;
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

        [HttpPost]
        public async Task<IActionResult> AssignToRole(PatronsAssignToRoleVM model)
        {
            if(model.PatronId == "none" || model.RoleId == "none")
                return RedirectToAction("Roles");

            var role = await this._roleManager.FindByIdAsync(model.RoleId);
            var patron = await this._userManager.FindByIdAsync(model.PatronId);

            var isInRole = await this._userManager.IsInRoleAsync(patron,role.Name);

            if(!isInRole)
                await this._userManager.AddToRoleAsync(patron,role.Name);
            
            return RedirectToAction("Roles");
        }

    }
}