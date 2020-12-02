using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MedelLibrary.Models;
using MedelLibrary.ViewModels;
using Microsoft.AspNetCore.Identity;

namespace MedelLibrary.Services
{
    public class PatronService : IPatron
    {
        private readonly SignInManager<Patron> _signInManager;
        private readonly UserManager<Patron> _userManager;
        private readonly ITransaction _transactions;


        public PatronService(SignInManager<Patron> signInManager, UserManager<Patron> userManager, ITransaction transactions)
        {
            this._signInManager = signInManager;
            this._userManager = userManager;
            this._transactions = transactions;
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
                ImageUrl = res.PersonalDetails.ImageUrl,
                PhoneNumber = res.PhoneNumber,
                Email = res.Email,
                LibraryCardId = res.LibraryCard.Id,
                PersonalDetailsId = res.PersonalDetails.Id
            });
        }

        public PatronModel GetPatronById(string id)
        {
            return this.GetAllPatrons().FirstOrDefault(p => p.Id == id);
        }

        public async Task<SignInResult> SignIn(SignInVM model)
        {
            return await this._signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false);
        }

        public async Task<Patron> SignUp(SignUpVM model)
        {
            var pDetails = new PersonalDetails()
                {
                    Firstname = model.Firstname,
                    Lastname = model.Lastname,
                    Address = model.Address
                };

                var patron = new Patron()
                {
                    UserName = model.Email,
                    Email = model.Email,
                    PhoneNumber = model.ContactNumber,
                    LibraryCard = this._transactions.CreateLibraryCard(),
                    PersonalDetails = pDetails
                };

            var res = await this._userManager.CreateAsync(patron, model.Password);
            return res.Succeeded ? patron : null;
        }
    }
}