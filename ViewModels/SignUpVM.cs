using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MedelLibrary.ViewModels
{
    public class SignUpVM
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        [DisplayName("Email Adress")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [MinLength(5)]
        [MaxLength(20)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [MinLength(5)]
        [MaxLength(20)]
        [Compare(nameof(Password))]
        [Display(Name="Confirm Password")]
        public string ConfirmPassword { get; set; }

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

        [Required]
        [DataType(DataType.PhoneNumber)]
        [DisplayName("Contact Number")]
        public string ContactNumber { get; set; }
    }
}