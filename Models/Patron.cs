using Microsoft.AspNetCore.Identity;

namespace MedelLibrary.Models
{
    public class Patron : IdentityUser
    {
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
    }
}