using System.Collections.Generic;
using System.Threading.Tasks;
using MedelLibrary.Models;
using MedelLibrary.ViewModels;
using Microsoft.AspNetCore.Identity;

namespace MedelLibrary.Services
{
    public interface IPatron
    {
        IEnumerable<Patron> GetAllPatrons();
        Patron GetPatronById(string id);
        Task<SignInResult> SignIn(SignInVM model);
        Task<Patron> SignUp(SignUpVM model);
        bool UpdatePatron(Patron patron);
        Task<bool> ChangePassword(Patron patron, string currentPassword, string newPassword);
    }
}