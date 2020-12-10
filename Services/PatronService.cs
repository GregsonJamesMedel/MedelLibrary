using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MedelLibrary.Data;
using MedelLibrary.Models;
using MedelLibrary.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace MedelLibrary.Services
{
    public class PatronService : IPatron
    {
        private readonly SignInManager<Patron> _signInManager;
        private readonly UserManager<Patron> _userManager;
        private readonly ITransaction _transactions;
        private readonly DataContext _context;


        public PatronService(SignInManager<Patron> signInManager,
                            UserManager<Patron> userManager,
                            ITransaction transactions,
                            DataContext context)
        {
            this._signInManager = signInManager;
            this._userManager = userManager;
            this._transactions = transactions;
            this._context = context;
        }

        public IEnumerable<Patron> GetAllPatrons()
        {
            return this._context.Users.Include(pd => pd.PersonalDetails).Include(lc => lc.LibraryCard);
        }

        public Patron GetPatronById(string id)
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

        public bool UpdatePatron(Patron patron)
        {
            var patronToUpdate = GetPatronById(patron.Id);

            if (patronToUpdate == null)
                return false;

            this._context.Users.Update(patronToUpdate);
            return this._context.SaveChanges() > 0;

        }
    }
}