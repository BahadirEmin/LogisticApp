using Microsoft.Win32;
using System.Windows;
using LogisticApp.Models;
namespace LogisticApp.Views
{
    public partial class AddTruckWindow : Window
    {
        public Truck NewTruck { get; set; }

        public AddTruckWindow()
        {
            InitializeComponent();
            NewTruck = new Truck();
            this.DataContext = NewTruck;
        }

        // Upload License Photo
        private void UploadLicensePhoto_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == true)
            {
                NewTruck.LicensePhoto = openFileDialog.FileName;
                MessageBox.Show("License photo uploaded successfully!");
            }
        }

        // Upload Truck Photo
        private void UploadTruckPhoto_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == true)
            {
                NewTruck.TruckPhoto = openFileDialog.FileName;
                MessageBox.Show("Truck photo uploaded successfully!");
            }
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            // Here you can add logic to save the new truck details
            MessageBox.Show("Truck added successfully!");
            this.Close();
        }
    }

    public class Truck
    {
        public string Model { get; set; }
        public string KM { get; set; }
        public string Driver { get; set; }
        public string LicensePhoto { get; set; } // Stores the file path of the license photo
        public string TruckPhoto { get; set; } // Stores the file path of the truck photo
    }
}
