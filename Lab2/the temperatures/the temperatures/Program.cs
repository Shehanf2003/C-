using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_temperatures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TemperatureTracker temperatures = new TemperatureTracker();
            temperatures.It();
            temperatures.Ot();
            Console.ReadLine();           
        }
    }
}
