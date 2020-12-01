using System;

namespace MedelLibrary.ViewModels
{
    public class CheckoutHistoryVM
    {
        public int Id { get; set; }
        public string AssetId { get; set; }
        public string Title { get; set; }
        public string AuthorOrDirector { get; set; }
        public string Type { get; set; }
        public int LibraryCardId { get; set; }
        public DateTime Checkout { get; set; }
        public DateTime? Checkin { get; set; }
    }
}