using System.ComponentModel.DataAnnotations;

namespace MedelLibrary.ViewModels
{
    public class SaveCategoryVM
    {
        public int? id { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(15)]
        public string Name { get; set; }
    }
}