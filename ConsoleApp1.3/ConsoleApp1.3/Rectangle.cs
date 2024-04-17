using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1._3
{
    internal class Rectangle : Shape

    {
        private double length;
        private double widht;

        public double Length
        {
            get { return length; }
            set { length = value; }

        }

        public double Widht
        {
            get { return widht; }
            set { widht = value; }
        }

        public Rectangle(double length, double widht)
        {
            Type = "Rectangle";
            Length = length;
            Widht = widht;
        }


        public override void CalculateArea()
        {
           Area= Length*Widht;
        }
    }
}
