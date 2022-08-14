using BookBiz_Management_System.BLL;
using BookBiz_Management_System.DAL;
using BookBiz_Management_System.GUI;
using System.Text.RegularExpressions;

namespace BookBiz_Management_System
{
    public partial class FrmBook : Form
    {
        private List<Author> authorList = AuthorDAL.GetAllAuthor();
        private List<Publisher> publisherList = PublisherDAL.GetAllPublishers();
        string authorNames = "";
        public string authorFromSubform;
        public string publisherFromSubform;

        private AutoCompleteStringCollection GenerateCollection(List<string> ts)
        {
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            ts.ForEach(el =>
            {
                collection.Add(el);
            });
            return collection;
        }
        public FrmBook()
        {
            InitializeComponent();
            //authorList = AuthorDAL.GetAllAuthor();
            //Set autocomplete property of authors textbox
            List<string> nameList = new List<string>();
            authorList.ForEach(el => {
                string name = el.FirstName + " " + el.LastName;
                nameList.Add(name);
            });
            var collection = GenerateCollection(nameList);
            TbxAuthor.AutoCompleteCustomSource = collection;
            TbxAuthor.AutoCompleteSource = AutoCompleteSource.CustomSource;
            TbxAuthor.AutoCompleteMode = AutoCompleteMode.Suggest;

            //Set data source of publisher combobox
            SetPublisherList();

            //Set Book datagridview datasource
            DgvBookList.DataSource = BookDAL.GetAllBooks();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void FrmBook_Load(object sender, EventArgs e)
        {

        }

        private void BtnSearchAuthor_Click(object sender, EventArgs e)
        {
            FrmAuthor frm = new FrmAuthor(this);
            frm.ShowDialog();
                authorNames += authorFromSubform + ";";
                TbxAuthor.Text = authorNames;
        }

        private void BtnAddPublisher_Click(object sender, EventArgs e)
        {
            FrmPublisher frmPublisher = new FrmPublisher(this);
            frmPublisher.ShowDialog();
            SetPublisherList();
            CbxPublisher.Text = publisherFromSubform;
        }

        private void SetPublisherList()
        {
            //Set data source of publisher combobox
            //step 1: get list of publisher name from publisherList
            List<string> publisherNameList = new List<string>();
            publisherList = PublisherDAL.GetAllPublishers();
            publisherList.ForEach(el =>
            {
                publisherNameList.Add(el.PublisherName);
            });
            //step 2: set datasource to list of publisher name
            CbxPublisher.DataSource = publisherNameList;
        }

        private void BtnAddClient_Click(object sender, EventArgs e)
        {
            //step 1: Set all input values to variables 
            string iSBN = TbxISBN.Text;
            string title = TbxTitle.Text;
            decimal unitPrice = Convert.ToDecimal(TbxUnitPrice.Text);
            int qOH = Convert.ToInt32(NudQOH.Value);
            string category = CbxCategory.Text;
            string publishYear = TbxPublishYear.Text;
            string publisherName = CbxPublisher.Text;
            string authors = TbxAuthor.Text;
            authorList = AuthorDAL.GetAllAuthor();

            //Step 2: Get all authors and save them to file
            string[] authorNames = authors.Split(';');
            foreach(string name in authorNames)
            {
                if(name == "")
                {
                    break;
                }
                string firstName = name.Split(' ')[0];
                string lastName = name.Split(' ')[1];

                int authorId = (from author in authorList
                         where author.FirstName == firstName && author.LastName == lastName
                         select author).ToList()[0].AuthorId;
                BookAuthorDAL.AddBookAuthor(new BookAuthor(iSBN,authorId));
            }

            //step 3: save book information to file
            BookDAL.AddBook(new Book(iSBN, title, unitPrice, qOH, category, publishYear, publisherName, authors));
            DgvBookList.DataSource = BookDAL.GetAllBooks();
        }

        private void BtnClearClientInfo_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void ClearAll()
        {
            TbxISBN.Clear();
            TbxTitle.Clear();
            TbxUnitPrice.Clear();
            NudQOH.Value = 1;
            CbxCategory.SelectedIndex = 0;
            TbxPublishYear.Clear();
            CbxPublisher.SelectedIndex = 0;
            TbxAuthor.Clear();
        }

        private void BtnSearchClient_Click(object sender, EventArgs e)
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
    }
}
