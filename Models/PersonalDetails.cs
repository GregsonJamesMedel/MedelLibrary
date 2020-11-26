using System;
using System.ComponentModel.DataAnnotations;

namespace MedelLibrary.Models
{
    public class PersonalDetails
    {
        public int Id { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(15)]
        public string Firstname { get; set; }

        [MinLength(2)]
        [MaxLength(15)]
        public string Middlename { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(15)]
        public string Lastname { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(50)]
        public string Address { get; set; }
        [MaxLength(10)]
        [MinLength(3)]
        public string Gender { get; set; }
        public string ImageUrl { get; set; }
        public DateTime Birthday { get; set; }
    }
}