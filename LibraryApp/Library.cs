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
        
        private Dictionary<int, Book> libraryBooks = new Dictionary<int, Book>();

        public Library(string name)
        {
            this.name = name;

            foreach (KeyValuePair<int, Book> book in GetAllBooks())
            {
                Console.WriteLine( book.Value.GetInfo());
            }
        }

        /// <summary>
        /// adds a book to the library
        /// </summary>
        /// <param name="book"></param>
        public void AddBook(Book book)
        {
           libraryBooks.Add(book.Id, book);


        }

        /// <summary>
        /// removes book from Dictionary 
        /// </summary>
        /// <param name="id"></param>
        public bool RemoveBook(int id) 
        {
            if (libraryBooks.ContainsKey(id))
            {
                libraryBooks.Remove(id);
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// returns a book object that has the same id in the libraryBook Dictionary
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Book GetBookById(int id)
        {
            if (libraryBooks.ContainsKey(id))
            {
                return libraryBooks[id];
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// returns the field LibraryBook
        /// </summary>
        /// <returns></returns>
        public Dictionary<int, Book> GetAllBooks()
        {
            return libraryBooks;
        }




        /// <summary>
        /// returns the all availlableBooks
        /// </summary>
        /// <returns></returns>
        public Dictionary<int, Book> GetAvailableBooks()
        {
            Dictionary<int, Book> availableBooks = new Dictionary<int, Book>();
            foreach(KeyValuePair<int, Book> book in libraryBooks)
            {
                if (!book.Value.IsBorrowd)
                {
                    availableBooks.Add(book.Key, book.Value);
                }
            }

            return availableBooks;
        }


        /// <summary>
        /// returns all the borrowed Books 
        /// </summary>
        /// <returns></returns>
        public Dictionary<int, Book> GetBorrowedBooks()
        {
            Dictionary<int, Book> borrowedBooks = new Dictionary<int, Book>();
            foreach (KeyValuePair<int, Book> book in libraryBooks)
            {
                if (book.Value.IsBorrowd)
                {
                    borrowedBooks.Add(book.Key, book.Value);
                }
            }

            return borrowedBooks;
        }




    }
}
