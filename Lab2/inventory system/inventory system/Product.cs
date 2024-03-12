using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_system
{
    internal class Product
    {
        public string productname;
        public double price;

        public Product(string productname, double price)
        {
            this.productname = productname;
            this.price = price;

            
        }
    }
}
