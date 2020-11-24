using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace MedelLibrary.ViewModels
{
    public class EditCoverVM
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string AuthorOrDirector { get; set; }
        public string ImageUrl { get; set; }
        [Required]
        public IFormFile Image { get; set; }
    }
}