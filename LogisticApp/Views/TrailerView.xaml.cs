using System.Collections.ObjectModel;
using System.Windows;
using LogisticApp.Views;
using LogisticsCRM.Views;  // Ensure the namespace for AddTrailerWindow is included

namespace LogisticsCRM.Views
{
    public partial class TrailerView : Window
    {
        public ObservableCollection<Trailer> Trailers { get; set; }

        public TrailerView()
        {
            InitializeComponent();

            // Initialize the collection
            Trailers = new ObservableCollection<Trailer>
            {
                new Trailer { Model = "Model 1" },
                new Trailer { Model = "Model 2" },
                new Trailer { Model = "Model 3" }
            };

            // Set the data context to the current instance of the view
            this.DataContext = this;
        }

        // Add Trailer Button Click Event Handler
        private void AddTrailerButton_Click(object sender, RoutedEventArgs e)
        {
            // Create and show the AddTrailerWindow
            AddTrailerWindow addTrailerWindow = new AddTrailerWindow();
            addTrailerWindow.ShowDialog();  // Shows the AddTrailerWindow as a modal
        }
    }

    public class Trailer
    {
        public string Model { get; set; }
    }
}
