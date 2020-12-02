using System.Collections.Generic;
using System.Threading.Tasks;
using MedelLibrary.ViewModels;
using Microsoft.AspNetCore.Identity;

namespace MedelLibrary.Services
{
    public interface IPatron
    {
        IEnumerable<PatronModel> GetAllPatrons();
        PatronModel GetPatronById(string id);
        Task<SignInResult> SignIn(SignInVM model);
    }
}