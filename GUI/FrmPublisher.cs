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
    public partial class FrmPublisher : Form
    {
        private List<Publisher> publishers = PublisherDAL.GetAllPublishers();
        private FrmBook frmBook;
        public string publisherName;
        public FrmPublisher(FrmBook frmBook)
        {
            this.frmBook = frmBook;
            InitializeComponent();
            DgvPublishers.DataSource = publishers;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            int publisherId = Convert.ToInt32(TbxPublisherId.Text);
            string publisherName = TbxPublisherName.Text;

            PublisherDAL.AddPublisher(new Publisher(publisherId, publisherName));
            MessageBox.Show("New Publisher has been added.");
            DialogResult = DialogResult.OK;
            PassPublisher(publisherName);
            this.Close();
        }

        private void PassPublisher(string publisherName)
        {
            
            frmBook.publisherFromSubform = publisherName;
            this.DialogResult = DialogResult.OK;
        }

        private void DgvPublishers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var cells = DgvPublishers.SelectedRows[0].Cells;
            string publisherId = cells[0].Value.ToString();
            string publisherName = cells[1].Value.ToString();

            PassPublisher(publisherName);

            this.Close();
        }
    }
}
