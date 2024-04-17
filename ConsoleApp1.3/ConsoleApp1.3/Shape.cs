using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1._3
{
    internal abstract class Shape
   
    {
        private string type;
        private double area;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public double Area
        {
            get { return area; }
            set { area = value; }
        }

        public abstract void CalculateArea();
        
        public virtual void DisplayShapeInfo()
        {
            Console.WriteLine($"Type:{Type}");
            Console.WriteLine($"Area:{Area}");
        }
       
        
    }
}
