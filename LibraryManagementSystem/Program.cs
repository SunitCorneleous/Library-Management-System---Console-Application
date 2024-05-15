using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.Library;

namespace LibraryManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LibraryApp library = new LibraryApp();

            while (true)
            {
                Console.WriteLine("/nLibrary Management System");
                Console.WriteLine("Select Option:");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Show All Books");
                
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        library.AddBook();
                        break;
                    case 2:
                        library.ShowAllBooks();
                        break;
                    default:
                        Console.WriteLine("Invalid Option!");
                        break;
                }
            }
        }
    }
}
