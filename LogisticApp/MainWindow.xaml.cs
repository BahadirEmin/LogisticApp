using System.Windows;
using LogisticApp.Views;
using LogisticsCRM.Views;  // Ensure you have the correct namespace for both views

namespace LogisticApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Navigate to Trailer View
        private void TrailerViewButton_Click(object sender, RoutedEventArgs e)
        {
            TrailerView trailerView = new TrailerView();  // This opens the TrailerView window
            trailerView.ShowDialog();  // Shows it as a modal window
        }

        // Navigate to Truck View
        private void TruckViewButton_Click(object sender, RoutedEventArgs e)
        {
            TruckView truckView = new TruckView();  // This opens the TruckView window
            truckView.ShowDialog();  // Shows it as a modal window
        }
    }
}
