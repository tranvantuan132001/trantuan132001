using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xBindDataExample.Models;

namespace xBindDataExample.Models
{

    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string CoverImage{ get; set; }
    }

    public class BookManger {
        public static List<Book> GetBooks()
           
        {
            var books = new List<Book>();

            books.Add(new Book { BookId = 1, Title = "Vulpale", Author = "Futurum", CoverImage = "Assets/1.png" });
            books.Add(new Book { BookId = 1, Title = "Mazim", Author = "Sequiter Que", CoverImage = "Assets/2.png" });
            books.Add(new Book { BookId = 1, Title = "Elit", Author = "Tempor", CoverImage = "Assets/3.png" });

            return books;
        }
    }

}
