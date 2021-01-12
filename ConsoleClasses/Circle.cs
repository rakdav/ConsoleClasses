using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClasses
{
    class Circle
    {
        private double Radius;
        private const double Pi = 3.14;
        public Circle(double radius)
        {
            Radius = radius;
        }

        private double getArea()
        {
            return Pi * Radius * Radius;
        }

        private double getPerimetr()
        {
            return 2*Pi * Radius;
        }
        public void Print()
        {
            Console.WriteLine("Радиус="+this.Radius+" Площадь="+getArea()+" Периметр="+getPerimetr());
        }
    }
}
