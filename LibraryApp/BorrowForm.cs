using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class BorrowForm : Form
    {
    
        private Book book;


        public BorrowForm(Book book)
        {
            InitializeComponent();
            this.book = book;
            lblBookInfo.Text = book.GetInfo();
        }

        private void btnTryToBorrow_Click(object sender, EventArgs e)
        {
            book.IsBorrowd = true;
            book.SetBorrowdInformation(tbBorrowerName.Text);

            Close();
        }

        #region not using
        private void BorrowForm_Load(object sender, EventArgs e)
        {

        }

        private void tbBorrowerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblBookInfo_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
