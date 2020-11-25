using System.ComponentModel.DataAnnotations;

namespace MedelLibrary.ViewModels
{
    public class SignInVM
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}