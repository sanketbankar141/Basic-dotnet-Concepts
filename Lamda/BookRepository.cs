using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamda
{
    public class Book
    {
        public string Title { get; set; }
        public int Price { get; set; }
    }
    public class BookRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() = { Title ="title 1",  Price = 500},
                new Book() = { Title = "title 2", Price = 50 },
                new Book() = { Title = "title 3", Price = 99 },
                new Book() = { Title = "title 4", Price = 457 }

            };
        }
    }
}
