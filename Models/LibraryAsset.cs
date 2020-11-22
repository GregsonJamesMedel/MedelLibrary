using System.ComponentModel.DataAnnotations;

namespace MedelLibrary.Models
{
    public abstract class LibraryAsset
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Year { get; set; }
        [Required]
        public string Status { get; set; }
        [Required]
        public decimal Cost { get; set; }
        public string ImageUrl { get; set; }
        public int NumberOfCopies { get; set; }
        public string Shelf { get; set; }
        public string Condition { get; set; }
        public Category Category { get; set; }
    }
}