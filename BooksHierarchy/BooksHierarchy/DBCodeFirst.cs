using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace BooksHierarchy
{
    public class DBClass
    {
        public void CreateData()
        {
            using (var db = new BooksContext())
            {
                if (!db.Authors.Any())          // Creating data in database is there isn't any yet
                {
                    var author1 = new Author() { Name = "John R. R. Tolkien" };
                    var year1_1 = new Year() { Name = "1954" };
                    var year1_2 = new Year() { Name = "1955" };
                    var book1_1 = new Book() { Name = "The Fellowship of the ring" };
                    var book1_2 = new Book() { Name = "The Two towers" };
                    var book1_3 = new Book() { Name = "The Return of the king" };

                    var author2 = new Author() { Name = "George R. R. Martin" };
                    var year2_1 = new Year() { Name = "1996" };
                    var year2_2 = new Year() { Name = "1998" };
                    var year2_3 = new Year() { Name = "2000" };
                    var year2_4 = new Year() { Name = "2005" };
                    var year2_5 = new Year() { Name = "2011" };
                    var book2_1 = new Book() { Name = "A Game of Thrones" };
                    var book2_2 = new Book() { Name = "A Clash of Kings" };
                    var book2_3 = new Book() { Name = "A Storm of Swords" };
                    var book2_4 = new Book() { Name = "A Feast for Crows" };
                    var book2_5 = new Book() { Name = "A Dance with Dragons" };

                    year1_1.Books.Add(book1_1);
                    year1_1.Books.Add(book1_2);
                    year1_2.Books.Add(book1_3);
                    year2_1.Books.Add(book2_1);
                    year2_2.Books.Add(book2_2);
                    year2_3.Books.Add(book2_3);
                    year2_4.Books.Add(book2_4);
                    year2_5.Books.Add(book2_5);

                    author1.Years.Add(year1_1);
                    author1.Years.Add(year1_2);
                    author2.Years.Add(year2_1);
                    author2.Years.Add(year2_2);
                    author2.Years.Add(year2_3);
                    author2.Years.Add(year2_4);
                    author2.Years.Add(year2_5);

                    db.Authors.Add(author1);
                    db.Authors.Add(author2);
                    db.SaveChanges();
                }
            }
        }
    }
    public class Author                     //the author class
    {
        public int authorId { get; set; }
        public string Name { get; set; }
        public virtual List<Year> Years { get; set; }
        public Author()
        {
            this.Years = new List<Year>();
        }
        public List<Author> ReadData()
        {
            var db = new BooksContext();
            var authors = db.Authors        //Reading data from database
            .Include(y => y.Years.Select(b => b.Books))
                .ToList();
            return authors;
        }
    }

    public class Year               //the year class
    {
        public int yearId { get; set; }
        public string Name { get; set; }
        public virtual Author Author { get; set; }
        public virtual List<Book> Books { get; set; }
        public Year()
        {
            this.Books = new List<Book>();
        }
    }

    public class Book           //the book class
    {
        public int bookId { get; set; }
        public string Name { get; set; }
        public virtual Year Year { get; set; }
    }

    class BooksContext : DbContext          //entity framework context
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Year> Years { get; set; }
        public DbSet<Book> Books { get; set; }
    }

}
