using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksHierarchy
{

        public class Author //the author class 
        {
            public int authorId { get; set; }
            public string Name { get; set; }
            public List<Year> Years { get; set; }
            public Author()
            {
                this.Years = new List<Year>();
            }
        }

        public class Year //the year class 
        {
            public int yearId { get; set; }
            public int authorId { get; set; }
            public string Name { get; set; }
            public List<Book> Books { get; set; }
            public Year()
            {
                this.Books = new List<Book>();
            }
        }

        public class Book //the book class 
        {
            public int bookId { get; set; }
            public string Name { get; set; }
            public int yearId { get; set; }
        }
    
}
