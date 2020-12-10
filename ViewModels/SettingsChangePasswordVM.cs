using System.ComponentModel.DataAnnotations;

namespace MedelLibrary.ViewModels
{
    public class SettingsChangePasswordVM
    {
        public string Id { get; set; }

        [MinLength(5)]
        [MaxLength(20)]
        [DataType(DataType.Password)]
        [Display(Name="Current Password")]
        public string CurrentPassword { get; set; }
        [MinLength(5)]
        [MaxLength(20)]
        [DataType(DataType.Password)]

        public string Password { get; set; }

        [MinLength(5)]
        [MaxLength(20)]
        [Compare(nameof(Password))]
        [DataType(DataType.Password)]
        [Display(Name="Confirm Password")]
        public string ConfirmPassword { get; set; }
    }
}