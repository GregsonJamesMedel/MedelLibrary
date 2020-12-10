using Microsoft.AspNetCore.Http;

namespace MedelLibrary.ViewModels
{
    public class SettingsProfilePhotoVM
    {
        public string Id { get; set; }
        public string ImagePath { get; set; }
        public IFormFile Image { get; set; }
    }
}