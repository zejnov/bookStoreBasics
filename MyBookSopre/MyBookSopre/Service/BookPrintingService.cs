using System;
using System.Collections.Generic;
using MyBookSopre.Model;

namespace MyBookSopre.Service
{
    public class BookPrintingService
    {
        public void Print(List<Book> books)
        {
            foreach (var book in books)
            {
                Console.WriteLine($"{book.Id}. {book.Title} by {book.Author}.");
            }
        }
    }
}
