using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace MedelLibrary.Models
{
    public class Patron : IdentityUser
    {
        public PersonalDetails PersonalDetails { get; set; }
    }
}