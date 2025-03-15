namespace LogisticApp.Models
{
    public class Truck
    {
        public string Model { get; set; }
        public string KM { get; set; }
        public string Driver { get; set; }
        public string CurrentLocation { get; set; }
        public string LicensePhoto { get; set; } // Stores the file path of the license photo
        public string TruckPhoto { get; set; } // Stores the file path of the truck photo
    }
}
