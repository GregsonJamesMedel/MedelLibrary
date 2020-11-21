using System.ComponentModel.DataAnnotations;

namespace MedelLibrary.ViewModels
{
    public class NewCategoryVM
    {
        public int id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}