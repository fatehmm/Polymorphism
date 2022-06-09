using System;

namespace Homework09JUNE
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            Product product1 = new Journal()
            {
                Name = "Wall Street Journal",
                Company = "Wall Street"

            };

            Product product2 = new Book()
            {
                Name = "Senanin maceralari",
                Genre = "Horror"

            };

            Product product3 = new Journal()
            {
                Name = "NY Times",
                Company = "Wall Street"

            };

            Product product4 = new Book()
            {
                Name = " maceralari",
                Genre = "Horror / Adventure"

            };

             
           
        }
    }
}

