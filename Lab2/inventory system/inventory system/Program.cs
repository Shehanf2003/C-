using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace inventory_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product("Js", 100);
            Console.WriteLine("Product Name is :"+product1.productname);
            Console.WriteLine("Product Price is :$" + product1.price);
            Console.ReadLine();
        }
    }
}
