using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library_system
{
    internal class LibraryBook
    {
        public string Title;
        public string Author;
        public bool Availability = true;

        public LibraryBook(string title, string author)
        {
            Title = title;
            Author = author;
            
           
        }
        public void BorrowBook()
        {
            if (Availability)
            {
                Availability = false;
                Console.WriteLine($"{Title} by {Author} Brorrowed");
               
            }
            else
            {
                Console.WriteLine($"{Title} by {Author} Available");
            }
        }
    }
}
