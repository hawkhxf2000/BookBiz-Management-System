using BookBiz_Management_System.BLL;
using BookBiz_Management_System.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookBiz_Management_System.GUI
{
    public partial class FrmOrderItem : Form
    {
        private List<Book> bookList = BookDAL.GetAllBooks();
        private FrmOrder frmOrder;
        private string itemName = "";
        public FrmOrderItem(FrmOrder frmOrder)
        {
            this.frmOrder = frmOrder;
            InitializeComponent();
            DgvBookList.DataSource = bookList;
        }

        private void BtnSearchBook_Click(object sender, EventArgs e)
        {
            //Step 1: initialize each search criteria
            string iSBN = "";
            string title = "";
            string author = "";

            ////step 2: check if textbox of search has no input, if yes, list all clients
            if (TbxSearchBy.Text == "")
            {
                DgvBookList.DataSource = BookDAL.GetAllBooks();
                return;
            }

            //Step 3: set value to search criteria selected
            int searchCriteria = CbxSearchBy.SelectedIndex;
            switch (searchCriteria)
            {
                case -1:
                    MessageBox.Show("Please choose one search option.");
                    break;
                case 0:
                    iSBN = TbxSearchBy.Text;
                    break;
                case 1:
                    title = TbxSearchBy.Text;
                    break;
                case 2:
                    author = TbxSearchBy.Text;
                    break;
                default:
                    break;
            }

            //step 4: Get list of client by selected search criteria
            List<Book> bookListFound = BookDAL.GetBooksDync(iSBN, title, author);

            //step 5: Show result on the page
            DgvBookList.DataSource = bookListFound;
        }

        private void BtnAddItem_Click(object sender, EventArgs e)
        {
            var rows = DgvBookList.SelectedRows;
            foreach(DataGridViewRow row in rows)
            {
                itemName += row.Cells[1].Value.ToString() + ";";
            }
            frmOrder.itemFromSubForm = itemName;
            this.Close();
        }
    }
}
