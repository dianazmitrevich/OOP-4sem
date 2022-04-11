using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Manufacturer
    {
        public int ID { get; set; }
        public string Name{ get; set; }
        public string Country { get; set; }
        public int Year { get; set; }

        public Manufacturer(int id, string name, string country, int year)
        {
            this.ID = id;
            this.Name = name;
            this.Country = country;
            this.Year = year;
        }
    }
}
