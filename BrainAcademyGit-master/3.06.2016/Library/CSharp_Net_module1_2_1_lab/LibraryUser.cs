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
        string _phone;
        string _FirstName;
        string _LastName;
        int _Id;
        string Phone
        {
            get { return _phone; }
            set {_phone = value; }
        }
        public string FirstName()
        {
            return this._FirstName;
        }
        public string LastName()
        {
            return this._LastName;
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

        public LibraryUser() { }
        public LibraryUser(string FirstName, string LastName, string Phone, int Booklimit) 
        {
            this._FirstName = FirstName;
            this._LastName = LastName;
            this._phone = Phone;
            this.BookLimit = BookLimit;
        }
        public void AddBook(string BookName)
        {
            for (int i = 0; i < 10; i++)
            {
                if (bookList[i] == null)
                {
                    bookList[i] = BookName;
                }
            }

        }
        public void RemoveBook(string BookName)
        {
            for (int i = 0; i < 10; i++)
            {
                if (bookList[i] == BookName)
                {
                    bookList[i] = null;
                }
            }
        }

        public string BookInfo(int index)
        {
            return bookList[index];
        }

        public int BooksCount()
        {
            int counter = 0;
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
