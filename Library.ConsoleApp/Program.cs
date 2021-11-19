using Library.Domain;
using Library.Persistance;
using System;

namespace Library.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Hobbit", "J. R. R. Tolkien", 1937, "12345", 15, 19.99m);
            BooksRepository repository = new BooksRepository();
        }
    }
}
