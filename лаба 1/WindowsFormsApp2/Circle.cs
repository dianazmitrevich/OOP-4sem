using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Circle : IComparable
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
        public int CompareTo(object Secondelement)
        {
            Circle secondElement = Secondelement as Circle;
            if (secondElement == null) return -1;

            if (this.Radius == secondElement.Radius) return 0;
            else if (this.Radius > secondElement.Radius) return 1;
            else return -1;
        }
    }
}
