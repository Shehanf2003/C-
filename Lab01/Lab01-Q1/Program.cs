using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Get the length of rectangle 
            Console.Write("Enter the Length of Rectangle -");
            int length = int.Parse(Console.ReadLine());

            //Get the width of rectangle
            Console.Write("Enter the Width of Rectangle -");
            int width = int.Parse(Console.ReadLine());

            //Calculate the area of rectangle
            int area = length * width;

            //Display the area of rectangle
            Console.WriteLine("The rectangle area is " + area);
            Console.ReadLine();

        }
    }
}
