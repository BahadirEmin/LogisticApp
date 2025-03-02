using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticApp.Models
{
    public class Trailer
    {
        public int Id { get; set; }
        public string LicensePlate { get; set; }
        public string Type { get; set; }
        public double Capacity { get; set; }
    }
}
