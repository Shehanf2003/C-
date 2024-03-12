using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace the_temperatures
{
    internal class TemperatureTracker
    {
        private const int numofdayinweek = 7;
        private double[] teperature;

        public TemperatureTracker()
        {
            teperature = new double[numofdayinweek];
        }
        public void It()
        {
            for(int i=0; i<numofdayinweek; i++)
            {
                Console.WriteLine($"Enter The Teperature in Day: {i + 1}");
                teperature[i] =double.Parse(Console.ReadLine());
            }
        }
        public void Ot()
        {
            Console.WriteLine("\nWeekly Teperature Report");
            for (int i = 0; i < numofdayinweek; i++)
            {
                Console.WriteLine($"Day: {i+1} Teperature {teperature[i]}");
            }
        }
        
    }
}

            





        
    


