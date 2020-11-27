using System;

namespace MedelLibrary.Models
{
    public class Hold
    {
        public int Id { get; set; }
        public virtual LibraryAsset LibraryAsset { get; set; }
        public virtual LibraryCard LibraryCard { get; set; }
        public DateTime HoldPlace { get; set; }
    }
}