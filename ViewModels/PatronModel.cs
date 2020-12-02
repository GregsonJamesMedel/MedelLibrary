using System;

namespace MedelLibrary.ViewModels
{
    public class PatronModel
    {
        public string Id { get; set; }
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public DateTime Birthday { get; set; }
        public string ImageUrl { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int LibraryCardId { get; set; }
        public int PersonalDetailsId { get; set; }
    }
}