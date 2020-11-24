using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MedelLibrary.Models;

namespace MedelLibrary.ViewModels
{
    public class EditBookVM
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Year { get; set; }
        public string Status { get; set; }
        [Required]
        public decimal Cost { get; set; }
        public string ImageUrl { get; set; }
        [Display(Name = "Number of Copies")]
        public int NumberOfCopies { get; set; }
        public string Shelf { get; set; }
        public string Condition { get; set; }
        [Required]
        public string ISBN { get; set; }
        [Required]
        public string Author { get; set; }
        public int Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}