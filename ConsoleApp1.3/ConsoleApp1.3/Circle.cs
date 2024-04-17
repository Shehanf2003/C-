using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1._3
{
    internal class Circle : Shape
    {
        private double radius;

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }
        public Circle(double radius) 
        {
            Type = "Circle";
            Radius = radius;
        }

       public override void CalculateArea()
        {
            Area = 3.14 * Radius * Radius;  
        }
    }
}
