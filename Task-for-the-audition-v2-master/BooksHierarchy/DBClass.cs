using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BooksHierarchy
{
    public class DBClass
    {
        public List<Author> DBData()            //connects to the database, reads the data and stores it in one list, whit it returns
        {
            Author auth = new Author();
            List<Author> listOfAuthors = new List<Author>();
            Year year = new Year();
            List<Year> listOfYears = new List<Year>();
            Book book = new Book();
            List<Book> listOfBooks = new List<Book>();
            SqlConnection connection = new SqlConnection("Server=.\\SQLEXPRESS;Database=AuthorsAndBooks;Integrated Security = True");       //path to the database
            connection.Open();
            SqlCommand cmd = new SqlCommand("Select Authors.Name, Authors.Id FROM Authors", connection);        //select all the authors names and Id's
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                auth.Name = reader.GetString(0);
                auth.authorId = reader.GetInt32(1);
                listOfAuthors.Add(auth);
                auth = new Author();
            }
            reader.Close();
            cmd = new SqlCommand("Select Years.Name, Years.Id, Years.authorId FROM Years", connection);         //select all the years and their Id's
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                year.Name = reader.GetString(0);
                year.yearId = reader.GetInt32(1);
                year.authorId = reader.GetInt32(2);
                listOfYears.Add(year);
                year = new Year();
            }
            reader.Close();
            cmd = new SqlCommand("Select Books.Name, Books.Id, Books.yearId FROM Books", connection);           //select all the books names and Id's
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                book.Name = reader.GetString(0);
                book.bookId = reader.GetInt32(1);
                book.yearId = reader.GetInt32(2);
                listOfBooks.Add(book);
                book = new Book();
            }
            reader.Close();
            connection.Close();
            int authIterator = 0, yearIterator = 0;       //inexes for upcoming loops

            foreach (Year tempYear in listOfYears)                      //adding every book to the according year, based on their Id's
            {
                foreach (Book tempBook in listOfBooks)
                {
                    if (tempYear.yearId == tempBook.yearId)
                    {
                        listOfYears[yearIterator].Books.Add(tempBook);
                    }
                }
                yearIterator++;
            }
            foreach (Author tempAuthor in listOfAuthors)                                  //adding every book to the according year, based on their Id's
            {
                foreach (Year tempYear in listOfYears)
                {
                    if (tempYear.authorId == tempAuthor.authorId)
                    {
                        listOfAuthors[authIterator].Years.Add(tempYear);
                    }
                }
                authIterator++;
            }
            return listOfAuthors;
        }
    }
}
