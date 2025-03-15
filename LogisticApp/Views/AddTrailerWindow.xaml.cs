using System;
using System.Windows;
using System.Windows.Input;

namespace LogisticApp.Views
{
    /// <summary>
    /// Interaction logic for AddTrailerWindow.xaml
    /// </summary>
    public partial class AddTrailerWindow : Window
    {
        // Define the NewTrailer object
        public Trailer NewTrailer { get; set; }

        // Constructor
        public AddTrailerWindow()
        {
            InitializeComponent();
            NewTrailer = new Trailer();  // Initialize the NewTrailer object
            this.DataContext = this;    // Set the DataContext to the current window
        }

        // Command for uploading a photo
        public ICommand UploadPhotoCommand => new RelayCommand(UploadPhoto);

        // Method to handle the upload photo logic
        private void UploadPhoto()
        {
            MessageBox.Show("Upload photo logic here.");
            // You can add logic for file dialogs to upload a photo here
        }

        // Command for saving the trailer
        public ICommand SaveCommand => new RelayCommand(SaveTrailer);

        // Method to handle the saving of the trailer
        private void SaveTrailer()
        {
            MessageBox.Show("Trailer saved successfully:\n" +
                $"Model: {NewTrailer.Model}\n" +
                $"Capacity: {NewTrailer.Capacity}\n" +
                $"Size: {NewTrailer.Size}\n" +
                $"Wheels: {NewTrailer.WheelCount}\n" +
                $"Awning: {NewTrailer.HasAwning}\n" +
                $"Refrigeration: {NewTrailer.HasRefrigeration}\n" +
                $"Chemicals: {NewTrailer.HasChemicals}\n" +
                $"Flammable: {NewTrailer.IsFlammable}");

            this.DialogResult = true; // Close window after saving
            this.Close();
        }
    }

    // Trailer class to hold data
    public class Trailer
    {
        public string Capacity { get; set; }
        public string Size { get; set; }
        public int WheelCount { get; set; }
        public string Model { get; set; }
        public bool HasAwning { get; set; }
        public bool HasRefrigeration { get; set; }
        public bool HasChemicals { get; set; }
        public bool IsFlammable { get; set; }
    }

    // RelayCommand class to handle commands
    public class RelayCommand : ICommand
    {
        private readonly Action _execute;

        public RelayCommand(Action execute)
        {
            _execute = execute;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter) => _execute();
    }
}
