using MyBookSopre.Service;

namespace MyBookSopre
{
    class Program
    {
        static void Main(string[] args)
        {
            new BookManagementService().Manage();
        }
    }
}
