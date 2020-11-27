using Microsoft.AspNetCore.Identity;

namespace MedelLibrary.Models
{
    public class Patron : IdentityUser
    {
        public PersonalDetails PersonalDetails { get; set; }
        public virtual LibraryCard LibraryCard { get; set; }
    }
}