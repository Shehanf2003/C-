using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(101, "John Doe", 50000);

            Console.WriteLine($"Employee{employee.ID} ");

            employee.Fullname = "John Doe";

            Console.WriteLine("Update the employee details");
            employee.Displayinfor();

            Console.ReadLine();
        }
        
    }
    
}
