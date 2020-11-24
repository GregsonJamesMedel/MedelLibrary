using Microsoft.AspNetCore.Http;

namespace MedelLibrary.ViewModels
{
    public class EditCoverVM
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string AuthorOrDirector { get; set; }
        public IFormFile image { get; set; }
    }
}