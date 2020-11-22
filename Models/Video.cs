using System.ComponentModel.DataAnnotations;

namespace MedelLibrary.Models
{
    public class Video : LibraryAsset
    {
        [Required]
        public string Director { get; set; }
    }
}