using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Manufacturer
    {
        public string ManufacturerName;
        public string ManufacturerCountry;
        public int ManufacturerYear;

        public Manufacturer() { }

        public Manufacturer(string name, string country, int year)
        {
            this.ManufacturerName = name;
            this.ManufacturerCountry = country;
            this.ManufacturerYear = year;
        }
    }
}
