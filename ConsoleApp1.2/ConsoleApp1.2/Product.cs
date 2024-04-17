using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1._2
{
    internal class Product
    {
        private int id;
        private string name;
        private double price;
        private int stock;

        public int Id
        {
            get { return id; }
            private set { id = value; }
            
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        public Product ( int Id, string Name, double Price, int Stock)
        {
            this.Id = Id;
            this.Name = Name;
            this.Price = Price;
            this.Stock = Stock;
        }

        public void Buyproduct()
        {
            Console.WriteLine($"Product ID {Id}");
            Console.WriteLine($"Product Name {Name}");
            Console.WriteLine($"Product Price ${Price}");
            Console.WriteLine($"quantity of the product {Stock}");
        }
        

        
    }
}
