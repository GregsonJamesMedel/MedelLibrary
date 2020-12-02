using System.Collections.Generic;
using System.Linq;
using MedelLibrary.Models;
using MedelLibrary.ViewModels;
using Microsoft.AspNetCore.Identity;

namespace MedelLibrary.Services
{
    public class PatronService : IPatron
    {
        private readonly SignInManager<Patron> _signInManager;
        private readonly UserManager<Patron> _userManager;


        public PatronService(SignInManager<Patron> signInManager, UserManager<Patron> userManager)
        {
            this._signInManager = signInManager;
            this._userManager = userManager;
        }

        public IEnumerable<PatronModel> GetAllPatrons()
        {
            return this._userManager.Users.Select(res => new PatronModel(){
                Id = res.Id,
                Firstname = res.PersonalDetails.Firstname,
                Middlename = res.PersonalDetails.Middlename,
                Lastname = res.PersonalDetails.Lastname,
                Gender = res.PersonalDetails.Gender,
                Address = res.PersonalDetails.Address,
                Birthday = res.PersonalDetails.Birthday,
                PhoneNumber = res.PhoneNumber,
                Email = res.Email,
                LibraryCardId = res.LibraryCard.Id,
                PersonalDetailsId = res.PersonalDetails.Id
            });
        }
    }
}