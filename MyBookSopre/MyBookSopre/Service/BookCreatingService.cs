using System;
using System.Collections.Generic;
using MyBookSopre.Model;

namespace MyBookSopre.Service
{
    public class BookCreatingService
    {
        public List<Book> Execute()
        {
            var bookList = new List<Book>();

            for (var i = 0; i < 3; i++)
            {
                Console.WriteLine("Please provide title:");
                var title = Console.ReadLine();
                Console.WriteLine("Please provide author:");
                var author = Console.ReadLine();

                bookList.Add(new Book
                {
                    Id = i,
                    Title = title,
                    Author = author
                });
            }
            return bookList;
        }  
    }
}
