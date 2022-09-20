using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using OpenFileDialog = System.Windows.Forms.OpenFileDialog;
using SaveFileDialog = System.Windows.Forms.SaveFileDialog;

namespace LibraryApp
{
    public partial class Form1 : Form
    {
        private static Library library;
       
        public Form1()
        {
            InitializeComponent();
            library = new Library("The Amazing Fontys Library");
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // checks if one of the two fields is empty or null
            if (String.IsNullOrEmpty(tbTitle.Text) || String.IsNullOrEmpty(tbAuthor.Text))
            {
                MessageBox.Show("please fill in the fields before adding a new book");
            }
            else
            {
                // checks if if value can be parsed
                if (int.TryParse(tbAvailability.Text, out int availability))
                {
                    for (int i = 0; i < availability; i++)
                    {
                        Book newBook = new Book(tbTitle.Text, tbAuthor.Text, GetRbBookType());
                        library.AddBook(newBook);

                        AddListItemsToListBox(library.GetAllBooks());
                    }
                }
                else
                {
                    MessageBox.Show("Please enther a numbrick value");
                }
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            //adds item to listbox
            AddListItemsToListBox(library.GetAllBooks());
        }

        private void btnShowBooksThatAre_Click(object sender, EventArgs e)
        {
           //checks which box is checked
            if (rbtnBorrowed.Checked)
            {
                AddListItemsToListBox(library.GetBorrowedBooks());
            }
            else if (rbtnAvailable.Checked)
            {
                AddListItemsToListBox(library.GetAvailableBooks());
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //checks if item exist and deletes it
            if (!library.RemoveBook(int.Parse(tbId.Text)))
            {
                MessageBox.Show("Sorry, no book with the specified id");
            }
            else
            {
                AddListItemsToListBox(library.GetAllBooks());
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
             // check if item exist and returns a book
            if (library.GetBookById(int.Parse(tbId.Text)) == null)
            {
                MessageBox.Show("Sorry, no book with the specified id");
            }
            else
            {
                library.GetBookById(int.Parse(tbId.Text)).IsBorrowd = false;
                AddListItemsToListBox(library.GetAllBooks());

            }
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            //checks if item exist or it all ready is borrowd
            if (library.GetBookById(int.Parse(tbId.Text)) == null)
            {
                MessageBox.Show("Sorry, no book with the specified id");
            }
            else if (library.GetBookById(int.Parse(tbId.Text)).IsBorrowd == true)
            {
                MessageBox.Show("Sorry, book is not available");
            }
            else
            {
                InitBorrowForm(library.GetBookById(int.Parse(tbId.Text)));
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //asks the user if he wants to save his proggess
            if (MessageBox.Show("Do you want to save your progress ?",
                               "Library Fontys",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Information) == DialogResult.Yes)
            {
                SaveFile();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //asks the user ig the wants to load his progress
            if (MessageBox.Show(
                "Do You want to load your progress",
                "Library Fontys",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information) == DialogResult.Yes)
            {
                LoadFile();
                AddListItemsToListBox(library.GetAllBooks());
            }
            else
            {
                DummeyBookData();
                AddListItemsToListBox(library.GetAllBooks());
            }
        }

        /// <summary>
        /// returns booktype that is connected to the radiobutton that is checked
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
        /// adds some books to listBox
        /// </summary>
        /// <param name="keyValues"></param>
        private void AddListItemsToListBox(List<Book> books)
        {
            lbLibrary.Items.Clear();
            foreach (Book book in books)
            {
                lbLibrary.Items.Add(book.GetInfo());
            }
        }

        /// <summary>
        /// initalaze the BorrowForm and parse
        /// </summary>
        /// <param name="book"></param>
        private void InitBorrowForm(Book book)
        {
            BorrowForm borrowForm = new BorrowForm(book);
            borrowForm.Show();
        }

        /// <summary>
        /// ask the user of he can save his progress in the file
        /// </summary>
        private void SaveFile()
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "save your progress";
            saveFileDialog1.FileName = "Library.bin";
            saveFileDialog1.ShowDialog();

                BinaryFile binaryFile = new BinaryFile(library);
                binaryFile.CreateBinaryFile(Path.GetFullPath(saveFileDialog1.FileName).ToString());
            
        }

        /// <summary>
        /// Loads in a binary file
        /// </summary>
        private void LoadFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "Load in your file";
            openFileDialog.ShowDialog();

            BinaryFile binaryFile = new BinaryFile(library);
            List<Book> valuePairs = binaryFile.ReadBinaryFile(Path.GetFullPath(openFileDialog.FileName).ToString());

            foreach (Book book in valuePairs)
            {
                library.AddBook(book);
            }
        }


        #region not using 
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void rbtnProgramming_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lbLibrary_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        #endregion


    }
}
