using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Plane
    {
        public int ID { get; set; }
        public string Type { get; set; }
        public string Model { get; set; }
        public int Capacity { get; set; }
        public int Year { get; set; }
        public string LoadCapacity { get; set; }
        public DateTime Maintenance { get; set; }
        public string Manufacturer { get; set; }

        public Plane(int id, string type, string model, int capacity, int year, string loadCapacity,
            DateTime maintenance, string manufacturer)
        {
            this.ID = id;
            this.Type = type;
            this.Model = model;
            this.Capacity = capacity;
            this.Year = year;
            this.LoadCapacity = loadCapacity;
            this.Maintenance = maintenance;
            this.Manufacturer = manufacturer;
        }
    }
}
