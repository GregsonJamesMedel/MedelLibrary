using System.Collections.Generic;
using MedelLibrary.Models;
using Microsoft.AspNetCore.Identity;

namespace MedelLibrary.ViewModels
{
    public class PatronsRolesVM
    {
        public IEnumerable<Patron> Patrons { get; set; }
        public IEnumerable<IdentityRole> Roles { get; set; }

    }
}