using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product(101,"Laptop",800,10);

            product.Buyproduct();
            Console.ReadLine();
        }
    }
}
