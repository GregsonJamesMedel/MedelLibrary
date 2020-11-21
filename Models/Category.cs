using System.ComponentModel.DataAnnotations;

namespace MedelLibrary.Models
{
    public class Category
    {
        public int id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}