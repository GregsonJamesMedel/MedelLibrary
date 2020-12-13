using System.Linq;
using MedelLibrary.Services;
using MedelLibrary.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace MedelLibrary.Controllers
{
    public class PatronsController : Controller
    {
        private readonly IPatron _patronService;

        public PatronsController(IPatron patronService)
        {
            _patronService = patronService;
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
    }
}