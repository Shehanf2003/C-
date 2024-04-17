using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1._1
{
    internal class Employee
    {
        public int ID { get; }
        public string Fullname { get; set; }
        private double salary;

        public Employee (int id, string fullname, double initialSalary)
        {
            ID = id;
            Fullname = fullname;
            salary = initialSalary;

            
          
        }

        public void Displayinfor()
        {
            Console.WriteLine($"Employee ID {ID}");
            Console.WriteLine($"Employee FullName {Fullname}");
            Console.WriteLine($"Employee Salary ${salary}");
        }

    }
}
