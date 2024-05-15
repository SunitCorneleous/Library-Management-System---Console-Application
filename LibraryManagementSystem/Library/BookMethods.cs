using ModelClassLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Library
{
    public class BookMethods
    {
        List<Book> books = new List<Book>();

        public void AddBook()
        {
            Book book = new Book();

            Console.WriteLine("Enter ISBN no.: ");
            book.ISBN =  Console.ReadLine();

            Console.WriteLine("Enter Title: ");
            book.Title = Console.ReadLine();

            Console.WriteLine("Enter Author: ");
            book.Author = Console.ReadLine();

            Console.WriteLine("Enter Author: ");
            book.Year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Author: ");
            book.IsBorrowed = Convert.ToBoolean(Console.ReadLine());
        }
    }
}
