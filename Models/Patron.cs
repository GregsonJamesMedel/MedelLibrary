using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace MedelLibrary.Models
{
    public class Patron : IdentityUser
    {
        [Required]
        [MinLength(2)]
        [MaxLength(15)]
        public string Firstname { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(15)]
        public string Middlename { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(15)]
        public string Lastname { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(50)]
        public string Address { get; set; }

    }
}