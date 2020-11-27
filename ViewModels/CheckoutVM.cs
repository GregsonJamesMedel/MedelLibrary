using System.Collections.Generic;

namespace MedelLibrary.ViewModels
{
    public class CheckoutVM
    {
        public int AssetId { get; set; }
        public string Title { get; set; }
        public string AuthorOrDirector { get; set; }
        public IEnumerable<PatronLibraryCardVM> Patrons { get; set; }
    }
}