using System.Collections.Generic;
using MedelLibrary.Models;

namespace MedelLibrary.ViewModels
{
    public class AssetVM
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Year { get; set; }
        public string Status { get; set; }
        public decimal Cost { get; set; }
        public string ImageUrl { get; set; }
        public int NumberOfCopies { get; set; }
        public string Shelf { get; set; }
        public string Condition { get; set; }
        public Category Category { get; set; }
        public string ISBN { get; set; }
        public string AuthorOrDirector { get; set; }
        public string Type { get; set; }
        public IEnumerable<Hold> Holds { get; set; }
        public IEnumerable<CheckoutHistory> CheckoutHistories { get; set; }
    }
}