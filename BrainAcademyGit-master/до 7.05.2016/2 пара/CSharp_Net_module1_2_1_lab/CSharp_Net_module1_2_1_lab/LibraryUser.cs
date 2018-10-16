using System;

namespace CSharp_Net_module1_2_1_lab
{

    // 1) declare interface ILibraryUser
    // declare method's signature for methods of class LibraryUser
    interface ILibraryUser
    {
        void AddBook(string BookName);
        void RemoveBook(string BookName);
        string BookInfo(int index);
        int BooksCount();
    }


    // 2) declare class LibraryUser, it implements ILibraryUser
    public class LibraryUser : ILibraryUser
    {
        readonly public string FirstName;
        readonly public string LastName;
        readonly int Id;
        string Phone
        {
            get; set;
        }
        readonly int BookLimit;
        string[] bookList = new string[10];

        public string this[int index_var]
        {
            get
            {
                string temp;
                if (index_var >= 0 && index_var <= 9)
                {
                    temp = bookList[index_var];
                }
                else
                {
                    temp = "";
                }
                return (temp);
            }
            set
            {
                if (index_var >= 0 && index_var <= 9)
                {
                    bookList[index_var] = value;
                }
            }
        }

        public LibraryUser(){}//конструктор
        public LibraryUser(string FirstName, string LastName, string Phone, int Booklimit){}//конструктор
        public void AddBook(string BookName)
        {
            bool added = false;
            for (int i = 0; i < 10; i++)
            {
                if (bookList[i] == null && added==false) 
                {
                    bookList[i] = BookName;
                    added = true;
                }
            }

        }
        public void RemoveBook(string BookName)
        {
            bool removed = false;
                for (int i = 0; i < 10; i++)
                {
                    if (bookList[i] == BookName && removed == false)
                    {
                        bookList[i] = null;
                        removed = true;
                    }
                }
        }

        public string BookInfo(int index)
        {
            return bookList[index];
        }

        public int BooksCount()
        {
            int counter=0;
            for (int i = 0; i < 10; i++)
            {
                if (bookList[i] != null) { counter++; }
            }
            return counter;
        }
    }

    // 3) declare properties: FirstName (read only), LastName (read only), 
    // Id (read only), Phone (get and set), BookLimit (read only)
 
    // 4) declare field (bookList) as a string array

 
    // 5) declare indexer BookList for array bookList
 
    // 6) declare constructors: default and parameter
 
    // 7) declare methods: 

        //AddBook() – add new book to array bookList
 
        //RemoveBook() – remove book from array bookList
 
        //BookInfo() – returns book info by index
 
        //BooksCout() – returns current count of books
  
}
