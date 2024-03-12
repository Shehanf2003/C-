using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Information
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1=new Book();

            book1.title = "Harry Potter ";
            book1.author = "J.K.Rowling";

            Console.WriteLine("The Book Title is "+book1.title);
            Console.WriteLine("The Book Author is " + book1.author);

            Console.ReadLine();
        }
    }
}
