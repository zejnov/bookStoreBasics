using System.Collections.Generic;
using MyBookSopre.Model;

namespace MyBookSopre.Service
{
    public class BookManagementService
    {
        public void Manage()
        {
            Execute();
            //ExecuteWhile();
            //ExecuteDoWhile();
        }

        public void Execute()
        {
            var bookList = new List<Book>();
            for (var i = 0; i < 10; i++)
            {
                bookList.Add(new Book()
                {
                    Id = i,
                    Author = "Jan",
                    Title = $"Title_{i}"
                });
            }
        }

        public void ExecuteWhile()
        {
            var bookList = new List<Book>();
            var i = 0;
            while (i < 10)
            {
                bookList.Add(new Book()
                {
                    Id = i,
                    Author = "Jan",
                    Title = $"Title_{i}"
                });
                i++;
            }
        }

        public void ExecuteDoWhile()
        {
            var bookList = new List<Book>();
            var i = 0;
            do
            {
                bookList.Add(new Book()
                {
                    Id = i,
                    Author = "Jan",
                    Title = $"Title_{i}"
                });
                i++;
            } while (i < 10);
        }
    }
}
