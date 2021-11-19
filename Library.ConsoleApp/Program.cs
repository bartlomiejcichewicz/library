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
            Console.Write("Login: ");
            string login = Console.ReadLine();
            Console.Write("Password: ");
            string password = Console.ReadLine();
            if (login == "Admin" && password == "password")
                Console.WriteLine("Access Granted");
            else
                Console.WriteLine("Access Denied");
            string input;
            do
            {
                Console.Clear();
                Console.WriteLine("Menu:");
                Console.WriteLine("[dodaj] [usun] [wypisz] [zmien] [dodaj zamowienie] [lista zamowien]");
                input = Console.ReadLine();
                if (input == "dodaj")
                    Console.WriteLine("proba dodania ksiazki");
                else if (input == "usun")
                    Console.WriteLine("proba usuniecia ksiazki");
                else if (input == "wypisz")
                    Console.WriteLine("proba wypisania wszystkich ksiazek");
                else if (input == "zmien")
                    Console.WriteLine("proba zmiany stanu magazynowego ksiazek");
                else if (input == "dodaj zamowienie")
                    Console.WriteLine("proba dodania nowego zamowienia");
                else if (input == "lista zamowien")
                    Console.WriteLine("proba wypisania wszystkich zamowien");
                else
                    Console.WriteLine("wybrana komenda nie jest wspierana");
            } while (input != "wyjdz"); 
        }
    }
}
