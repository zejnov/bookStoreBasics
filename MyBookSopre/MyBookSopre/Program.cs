using System;
using MyBookSopre.Service;

namespace MyBookSopre
{
    class Program
    {
        static void Main(string[] args)
        {
            //new BookManagementService().Manage();
            var books = new BookCreatingService().Execute();
            new BookPrintingService().Print();
            Console.ReadLine();
        }
    }
}
