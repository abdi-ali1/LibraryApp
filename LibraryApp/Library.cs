using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
   public class Library
    {
        private string name;
        
        private List<Book> libraryBooks = new List<Book>();
 

        public Library(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// adds a book to the library
        /// </summary>
        /// <param name="book"></param>
        public void AddBook(Book book)
        {
           libraryBooks.Add( book);

        }

        /// <summary>
        /// removes book from list of books 
        /// </summary>
        /// <param name="id"></param>
        public bool RemoveBook(int id) 
        {
            bool status = false;
            for (int i = 0; i < libraryBooks.Count; i++)
            {
                if (libraryBooks[i].Id == id)
                {
                    libraryBooks.RemoveAt(i);
                    status = true;
                }
            }

            return status;
        }
        
        
        /// <summary>
        /// returns a book object that has the same id in the libraryBook list
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Book GetBookById(int id)
        {
            Book book = null;

            foreach (Book b in libraryBooks)
            {
                if (b.Id == id)
                {
                    book = b;
                }
            }

            return book;
        }


        /// <summary>
        /// returns the field LibraryBook
        /// </summary>
        /// <returns></returns>
        public List<Book> GetAllBooks()
        {
            return libraryBooks;
        }


        /// <summary>
        /// returns the all availlableBooks
        /// </summary>
        /// <returns></returns>
        public List<Book> GetAvailableBooks()
        {
            List<Book> availableBooks = new List<Book>();
            foreach(Book book in libraryBooks)
            {
                if (!book.IsBorrowd)
                {
                    availableBooks.Add(book);
                }
            }
                
            return availableBooks;
        }


        /// <summary>
        /// returns all the borrowed Books 
        /// </summary>
        /// <returns></returns>
        public List<Book> GetBorrowedBooks()
        {
          List<Book> borrowedBooks = new List<Book>();
            foreach (Book book in libraryBooks)
            {
                if (book.IsBorrowd)
                {
                    borrowedBooks.Add(book);
                }
            }

            return borrowedBooks;
        }




    }
}
