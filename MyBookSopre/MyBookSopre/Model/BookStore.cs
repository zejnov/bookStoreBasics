using System.Collections.Generic;

namespace MyBookSopre.Model
{
    public class BookStore
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public string Adress { get; set; }

        public List<Book> Books { get; set; }
    }
}
