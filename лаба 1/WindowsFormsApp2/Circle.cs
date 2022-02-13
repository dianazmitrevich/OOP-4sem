using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Circle
    {
        public int Radius { get; set; }

        public Circle (int radius = 0)
        {
            this.Radius = radius;
        }

        public override string ToString()
        {
            return $"Радиус круга = {this.Radius}";
        }
    }
}
