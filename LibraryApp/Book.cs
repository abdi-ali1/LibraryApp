using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
  [Serializable]
  public class Book
    {

        private static int autoIncrementCounter = 0;
        private int id = 99;
         
        private string title;
        private string author;
        private string borrowedInfo = "No info";
        private bool isBorrowd = false;

        private BookType bookType;



        public int Id { get { return id; } }
        public string Title { get { return title; } }
        public string Author { get { return author; } }
        public string BorrowedInfo { get { return borrowedInfo; } }
        public BookType BookType { get { return bookType; } }
        public bool IsBorrowd { get { return isBorrowd; } set { isBorrowd = value; } }


        public Book(string title, string author, BookType bookType)
        {
            this.title = title;
            this.author = author;
            this.bookType = bookType;


             AutoIncrementId();
        }


        /// <summary>
        /// returns a string with some information about this object
        /// </summary>
        /// <returns>string with information about this object</returns>
        public string GetInfo()
        {
            string returnText;
            if (isBorrowd)
            {
              return returnText = $"ID:{id}, Title:{title}, Author:{author}, BookType:{bookType}, Borrowed By:{borrowedInfo}";
            }
            else
            {
              return returnText = $"ID:{id}, Title:{title}, Author:{author}, BookType:{bookType}";
            }
        }

        /// <summary>
        /// sets if a book is borrowd and its infomation
        /// </summary>
        /// <param name="info"></param>
        public void SetBorrowdInformation(string info)
        {
            borrowedInfo = info;
            isBorrowd = true;
        }

       /// <summary>
       /// increments the given value
       /// </summary>
       /// <param name="value"></param>
       /// <returns></returns>
        private void AutoIncrementId()
        {
       
           id += System.Threading.Interlocked.Increment(ref autoIncrementCounter);
        }
    }
}
