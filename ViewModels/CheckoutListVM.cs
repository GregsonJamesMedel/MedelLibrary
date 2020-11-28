using System;

namespace MedelLibrary.ViewModels
{
    public class CheckoutListVM
    {
        public int CheckoutId { get; set; }
        public string AssetTitle { get; set; }
        public string AuthorOrDirector { get; set; }
        public string AssetType { get; set; }
        public int LibraryCardId { get; set; }
        public DateTime Since { get; set; }
        public DateTime Until { get; set; }
    }
}