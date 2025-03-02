using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogisticApp.Models;

namespace LogisticApp.ViewModels
{
    public class TruckViewModel
    {
        private readonly DataRepository<Truck> _truckRepository;
        public List<Truck> Trucks { get; private set; }

        public TruckViewModel()
        {
            _truckRepository = new DataRepository<Truck>("trucks.json");
            Trucks = _truckRepository.Load();
        }

        public void AddTruck(Truck truck)
        {
            Trucks.Add(truck);
            _truckRepository.Save(Trucks);
        }
    }
}
