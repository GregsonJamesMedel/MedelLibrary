using System;

namespace MedelLibrary.ViewModels
{
    public class SettingsPersonalDetailsVM
    {
        
        public string Id { get; set; }
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
        public string Gender { get; set; }
        public DateTime Birthday { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }

    }
}