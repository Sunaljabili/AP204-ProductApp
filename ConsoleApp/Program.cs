using System;
using Models;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Book book = new Book();
            book.Name = "Qaranliq";
            book.Author = "Tural";
            book.Genre = "Roman";
            book.Price = 23.99;

            Book book1 = new Book();
            book1.Name = "Sefirler";
            book1.Author = "Eli";
            book1.Genre = "Fantastik";
            book1.Price = 10.99;

            Library library = new Library();

            library.AddProduct(book);
            library.AddProduct(book1);


            foreach (var item in library.GetProductByPrice(22,50))
            {
                item.GetInfo();
            }

            foreach (var item in library.GetProductsByName("Sefirler"))
            {

                item.GetInfo();
            }

        }
    }
}
