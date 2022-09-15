﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibraryApp
{
    public partial class Form1 : Form
    {
        private static Library library;
        private FormClosingEventHandler frmMain_FormClosing;

        public Form1()
        {
            InitializeComponent();
      
            library = new Library("The Amazing Fontys Library");
            DummeyBookData();
            AddDictionaryItemsToListBox(library.GetAllBooks());
   

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(tbTitle.Text) || String.IsNullOrEmpty(tbAuthor.Text))
            {
                MessageBox("please fill the fields before adding a new book");
            }
            else
            {
                if (int.TryParse(tbAvailability.Text, out int availability))
                {
                    for (int i = 0; i < availability; i++)
                    {
                        Book newBook = new Book(tbTitle.Text, tbAuthor.Text, GetRbBookType());
                        library.AddBook(newBook);

                        AddDictionaryItemsToListBox(library.GetAllBooks());
                    }
                }
                else
                {
                    MessageBox("Please enther a numbrick value");
                }
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            AddDictionaryItemsToListBox(library.GetAllBooks());
        }

        private void btnShowBooksThatAre_Click(object sender, EventArgs e)
        {
            if (rbtnBorrowed.Checked)
            {
                AddDictionaryItemsToListBox(library.GetBorrowedBooks());
            }
            else if (rbtnAvailable.Checked)
            {
                AddDictionaryItemsToListBox(library.GetAvailableBooks());
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (!library.RemoveBook(int.Parse(tbId.Text)))
            {
                MessageBox("Sorry, no book with the specified id");
            }
            else
            {
                AddDictionaryItemsToListBox(library.GetAllBooks());
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (library.GetBookById(int.Parse(tbId.Text)) == null)
            {
                MessageBox("Sorry, no book with the specified id");
            }
            else
            {
                library.GetBookById(int.Parse(tbId.Text)).IsBorrowd = false;
            }
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            if (library.GetBookById(int.Parse(tbId.Text)) == null)
            {
                MessageBox("Sorry, no book with the specified id");
            }
            else if (library.GetBookById(int.Parse(tbId.Text)).IsBorrowd == true)
            {
                MessageBox("Sorry, book is not available");
            }
            else
            {
                GetBorrowForm(library.GetBookById(int.Parse(tbId.Text)));
            }
        }

        private void lbLibrary_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// returns booktype that is connected to the radiobutton
        /// </summary>
        /// <returns></returns>
        private BookType GetRbBookType()
        {

            if (rbtnDatabase.Checked)
            {
                return BookType.DATABASE;
            }
            else if (rbtnMiscellaneous.Checked)
            {
                return BookType.MISCELLANEOUS;
            }
            else
            {
                return BookType.PROGRAMMING;
            }

         
        }

        /// <summary>
        /// shows a MessageBox with
        /// </summary>
        /// <param name="message"> the message that is shown</param>
        private void MessageBox(string message)
        {
            System.Windows.Forms.MessageBox.Show(message);
        }

        /// <summary>
        /// some dummy data that is added to the library
        /// </summary>
        private void DummeyBookData()
        {
            library.AddBook(new Book("C# for students", "Dough Bell", BookType.PROGRAMMING));
            library.AddBook(new Book("C# for students", "Dough Bell", BookType.PROGRAMMING));
            library.AddBook(new Book("C# for students", "Dough Bell", BookType.PROGRAMMING));
            library.AddBook(new Book("C# 7.0 in a nutshell", "Ben Albarhari", BookType.PROGRAMMING));
            
            library.AddBook(new Book("C# in Depth", "Jon SKeet", BookType.PROGRAMMING));
            library.AddBook(new Book("C# for students", "Dough Bell", BookType.PROGRAMMING));
        }
        
        /// <summary>
        /// adds some items to the form l
        /// </summary>
        /// <param name="keyValues"></param>
        private void AddDictionaryItemsToListBox(Dictionary<int, Book> keyValues)
        {
            lbLibrary.Items.Clear();
            foreach (KeyValuePair<int, Book> book in keyValues)
            {
                lbLibrary.Items.Add(book.Value.GetInfo());
            }
        }

        /// <summary>
        /// initalaze the BorrowForm and parse
        /// </summary>
        /// <param name="book"></param>
        private void GetBorrowForm(Book book)
        {
            BorrowForm borrowForm = new BorrowForm(book);
            borrowForm.Show();
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (System.Windows.Forms.MessageBox.Show("Do you want to save your prograss ?",
                               "Library Fontys",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Information) == DialogResult.Yes)
            {
                BinaryFile binaryFile = new BinaryFile(library);
                binaryFile.CreateBinaryFile();
                SaveFile();
            }
        }


        private void SaveFile()
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "BIN files| (*.bin)";
            saveFileDialog1.FileName = "Library.bin";
            saveFileDialog1.Title = "save your progress";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
       
                System.IO.FileStream fs =
                    (System.IO.FileStream)saveFileDialog1.OpenFile();
               


                fs.Close();
            }
        }



        #region not using 
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void rbtnProgramming_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        #endregion


    }
}