using System;
using System.ComponentModel.DataAnnotations;

namespace MedelLibrary.Models
{
    public class CheckoutHistory
    {
        public int Id { get; set; }
        [Required]
        public LibraryAsset LibraryAsset { get; set; }
        [Required]
        public LibraryCard LibraryCard { get; set; }
        public DateTime? Checkin { get; set; }
        [Required]
        public DateTime Checkout { get; set; }
    }
}