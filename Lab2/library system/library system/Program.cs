using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LibraryBook libraryBook1 = new LibraryBook("Harry Potter and the Philosopher’s Stone", "J. K. Rowling");
            LibraryBook libraryBook2 = new LibraryBook("Harry Potter and the Chamber of Secrets", "J. K. Rowling");
            LibraryBook libraryBook3 = new LibraryBook("Harry Potter and the Prisoner of Azkaban", "J. K. Rowling");

            

            Console.WriteLine("\nLibrary Book Status");
           libraryBook1.BorrowBook();
            libraryBook2.BorrowBook();
            libraryBook3.BorrowBook();
            Console.ReadLine();
        }
    }
}
