using BookBiz_Management_System.BLL;
using BookBiz_Management_System.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookBiz_Management_System.GUI
{
    
    public partial class FrmAuthor : Form
    {
        private List<Author> authorList = AuthorDAL.GetAllAuthor();
        //private List<Book> bookList = BookDAL.GetAllBooks();
        private FrmBook frmBook;
        private string authorName;

      
        public FrmAuthor(FrmBook frmBook)
        {
            this.frmBook = frmBook; 
            InitializeComponent();
            DgvAuthorList.DataSource = authorList;
        }

        private void BtnAddAuthor_Click(object sender, EventArgs e)
        {
            //step 1: Get input information and set to variables
            int authorId = Convert.ToInt32(TbxAuthorId.Text);
            string firstName = TbxFirstName.Text;
            string lastName = TbxLastName.Text;
            string email = TbxEmail.Text;
            //step 2: create an author object and save to file
            var author = new Author(authorId, firstName, lastName, email);
            AuthorDAL.AddAuthor(author);
            //step 3: show the new list on table
            List<Author> authors = AuthorDAL.GetAllAuthor();
            DgvAuthorList.DataSource = authors;
            //step 4: Show confirmation message
            MessageBox.Show("New author has been saved. And it will add to current book" );
            //step 5: pass the author name to book form
            PassName(firstName, lastName);
            this.Close();
        }

        //Search Authors By name
        private void BtnSearchAuthor_Click(object sender, EventArgs e)
        {
            //Step 1: initialize each search criteria
            int authorId = 0;
            string firstName = "";
            string lastName = "";
            string email = "";

            //step 2: check if textbox of search has no input, if yes, list all clients
            if (TbxSearchBy.Text == "")
            {
                DgvAuthorList.DataSource = ClientDAL.GetAllClients();
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
                    firstName = TbxSearchBy.Text;
                    break;
                case 1:
                    lastName = TbxSearchBy.Text;
                    break;
                default:
                    break;
            }

            //step 4: Get list of client by selected search criteria
            List<Author>? authorsFound = AuthorDAL.GetAuthorByName(firstName, lastName);
            if(authorsFound != null)
            {
                MessageBox.Show("There is no author found!");
                TbxSearchBy.Focus();
            }
            //step 5: Show result on the page
            DgvAuthorList.DataSource = authorsFound;
        }

        private void PassName(string firstName, string lastName)
        {
            this.authorName = firstName + " " + lastName;
            frmBook.authorFromSubform = this.authorName;
            this.DialogResult = DialogResult.OK;
        }

        private void BtnAddToBook_Click(object sender, EventArgs e)
        {
            string firstName = DgvAuthorList.SelectedRows[0].Cells[1].Value.ToString();
            string lastName = DgvAuthorList.SelectedRows[0].Cells[2].Value.ToString();
            PassName(firstName, lastName);
            this.Close();
        }
    }

        
    }
