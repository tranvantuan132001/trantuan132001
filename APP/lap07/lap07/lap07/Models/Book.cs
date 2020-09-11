using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap07
{
   public class Book  
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string CoverImage{ get; set; }
    }
    public class BookManager
    {
        public static List<Book> GetBooks()
        {
            var books = new List<Book>();
            books.Add(new Book { BookId = 1, Title = "Vulpate", Author = "Futurum", CoverImage = "Asssets/1.npg" });
            books.Add(new Book { BookId = 2, Title = "MaZim", Author = "Sequiter", CoverImage = "Asssets/2.npg" });
            books.Add(new Book { BookId = 1, Title = "Elit", Author = "Tempor", CoverImage = "Asssets/3.npg" });

        }
    }

}

