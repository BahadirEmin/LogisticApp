using System.Collections.ObjectModel;
using System.Windows;

namespace LogisticApp.Views
{
    public partial class TruckView : Window
    {
        public ObservableCollection<Truck> Trucks { get; set; }

        public TruckView()
        {
            InitializeComponent();

            // Initialize the collection
            Trucks = new ObservableCollection<Truck>
            {
                new Truck { Model = "Truck 1" },
                new Truck { Model = "Truck 2" },
                new Truck { Model = "Truck 3" }
            };

            // Set the data context to the current instance of the view
            this.DataContext = this;
        }

        // Add Truck Button Click Event Handler
        private void AddTruckButton_Click(object sender, RoutedEventArgs e)
        {
            AddTruckWindow addTruckWindow = new AddTruckWindow();
            addTruckWindow.ShowDialog();
        }
    }

   
}
