using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(9, 7);
            rectangle.CalculateArea();
            rectangle.DisplayShapeInfo();

            Circle circle = new Circle(4);
            circle.CalculateArea();
            circle.DisplayShapeInfo();


            
           

            Console.ReadLine();

        }
    }
}
