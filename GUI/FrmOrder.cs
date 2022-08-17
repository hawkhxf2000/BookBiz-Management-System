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
    public partial class FrmOrder : Form
    {
        private List<Client> clients;
        private List<Book> bookList;
        public string itemFromSubForm;

        private AutoCompleteStringCollection GenerateCollection(List<string> ts)
        {
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            ts.ForEach(el =>
            {
                collection.Add(el);
            });
            return collection;
        }
        public FrmOrder()
        {
            InitializeComponent();
            ClientAutoComplete();
            BookAutoComplete();

            DgvOrderList.DataSource = OrderRecordDAL.GetAllOrderRecords();
        }

        private void ClientAutoComplete()
        {
            clients = ClientDAL.GetAllClients();
            //Set autocomplete property of authors textbox
            List<string> nameList = new List<string>();
            clients.ForEach(el =>
            {
                nameList.Add(el.ClientName);
            });
            var collection = GenerateCollection(nameList);
            TbxClientName.AutoCompleteCustomSource = collection;
            TbxClientName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            TbxClientName.AutoCompleteMode = AutoCompleteMode.Suggest;
        }

        private void BookAutoComplete()
        {
            bookList = BookDAL.GetAllBooks();
            //Set autocomplete property of authors textbox
            List<string> titleList = new List<string>();
            bookList.ForEach(el =>
            {
                titleList.Add(el.Title);
            });
            var collection = GenerateCollection(titleList);
            TbxBookTitle.AutoCompleteCustomSource = collection;
            TbxBookTitle.AutoCompleteSource = AutoCompleteSource.CustomSource;
            TbxBookTitle.AutoCompleteMode = AutoCompleteMode.Suggest;
        }

        private void FrmOrder_Load(object sender, EventArgs e)
        {

        }

        private void TbxClientName_Leave(object sender, EventArgs e)
        {
            //Get all client list
            clients = ClientDAL.GetAllClients();

            //get input client name and query by it
            string clientName = TbxClientName.Text;
            if (string.IsNullOrEmpty(clientName))
            {
                MessageBox.Show("Client name must not be empty!");
                TbxClientName.Focus();
                return;
            }
            
            List<Client> clientsFound = (from el in clients
                                  where el.ClientName == clientName
                                  select el).ToList();
            if(clientsFound.Count == 0)
            {
                MessageBox.Show("There is no such a client found!");
                TbxClientName.Focus();
                return;
            }
            Client client = clientsFound[0];
            //show the client information on page
            TbxPhoneNumber.Text = client.PhoneNumber;
            TbxFaxNumber.Text = client.FaxNumber;
            TbxEmail.Text = client.Email;
            TbxBankAccount.Text = client.BankAccount;
        }

        private void BtnAddItems_Click(object sender, EventArgs e)
        {
            OrderItem item = new OrderItem();
            string bookTitle = TbxBookTitle.Text;
            if (string.IsNullOrEmpty(bookTitle))
            {
                MessageBox.Show("Book title must not be empty!");
                TbxBookTitle.Focus();
                return;
            }
            List<Book> books = BookDAL.GetAllBooks();
            List<Book> booksFound = (from el in books
                                     where el.Title == bookTitle
                                     select el).ToList();
            if(booksFound == null)
            {
                MessageBox.Show("There is no such a Book found!");
                TbxBookTitle.Focus();
                return;
            }
            item.ISBN = booksFound[0].ISBN;
            item.Title = bookTitle;
            item.OrderId = MtxOrderNumber.Text;
            item.Quantity = Convert.ToInt32(NudQuantity.Value);

            OrderItemDAL.AddOrderItem(item);

            List<OrderItem>? orderItems= OrderItemDAL.GetItemDync(item.OrderId,"");
            DgvBookItems.DataSource = orderItems;
            TbxBookTitle.Clear();
            NudQuantity.Value = 1;

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void ClearAll()
        {
            MtxOrderNumber.Clear();
            TbxClientName.Clear();
            TbxPhoneNumber.Clear();
            CbxOrderMethod.SelectedIndex = 0;
            TbxFaxNumber.Clear();
            TbxBankAccount.Clear();
            TbxEmail.Clear();
            TbxBookTitle.Clear();
            DgvBookItems.DataSource = null;
        }

        private void BtnAddOrder_Click(object sender, EventArgs e)
        {
            //step 1: Set all input values to variables 
            string orderId = MtxOrderNumber.Text;
            string clientName = TbxClientName.Text;
            string orderMethod= CbxOrderMethod.Text;
            //int quantity = Convert.ToInt32(NudQuantity.Text);
            //string bookTitle = TbxBookTitle.Text;

            //bookList = BookDAL.GetAllBooks();

            ////Step 2: Get all authors and save them to file
            //string[] bookTitles = itemFromSubForm.Split(';');
            //foreach (string title in bookTitles)
            //{
            //    if (title == "")
            //    {
            //        break;
            //    }

            //    string iSBN = (from book in bookList
            //                    where book.Title == title
            //                    select book).ToList()[0].ISBN;
            //    OrderItemDAL.AddOrderItem(new OrderItem(orderId, iSBN, title, quantity));
            //}

            //step 2: save order information to file
            //2.1: check if the orderItem relate to this order is not null
            List<OrderItem> items = OrderItemDAL.GetAllOrderItem();
            List<OrderItem> itemsFound = (from el in items
                         where el.OrderId == orderId
                         select el).ToList();
            if(itemsFound.Count == 0)
            {
                MessageBox.Show("The order can't be empty, please check what book you want to order!");
            }
            //2.2 save the Order record to file
            OrderRecordDAL.AddOrderRecord(new OrderRecord(orderId, clientName, orderMethod));

            //step 3: refresh the order list table and clear all input field
            DgvOrderList.DataSource = OrderRecordDAL.GetAllOrderRecords();
            ClearAll();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var orderId = DgvOrderList.SelectedRows[0].Cells[0].Value.ToString();
            OrderRecordDAL.Delete(orderId);
            DgvOrderList.DataSource = OrderRecordDAL.GetAllOrderRecords();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void BtnDeleteOrderItem_Click(object sender, EventArgs e)
        {
            string? orderId = DgvBookItems.SelectedRows[0].Cells[0].Value.ToString();
            string? iSBN = DgvBookItems.SelectedRows[0].Cells[1].Value.ToString();
            DialogResult af = MessageBox.Show("Are you sure to delete the item?", "Confirm", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);
            if(af == DialogResult.OK)
            {
                OrderItemDAL.Delete(orderId, iSBN);
                DgvBookItems.DataSource = OrderItemDAL.GetAllOrderItem();
            }
        }

        private void BtnSearchOrder_Click(object sender, EventArgs e)
        {
            String orderId = "";
            string clientName = "";
            int option = CbxSearchBy.SelectedIndex;
            string sText = TbxSearchBy.Text;

            if(sText == "")
            {
                DgvOrderList.DataSource = OrderRecordDAL.GetAllOrderRecords();
            }
            else if(option == 0)
            {
                orderId = sText;
            }
            else
            {
                clientName = sText;
            }
            DgvOrderList.DataSource = OrderRecordDAL.GetOrderDync(orderId, clientName);
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            string orderId = MtxOrderNumber.Text;
            string clientName = TbxClientName.Text;
            string orderMethod = CbxOrderMethod.Text;

            var order = new OrderRecord(orderId, clientName, orderMethod);

            OrderRecordDAL.UpdateOrder(order);

            DgvOrderList.DataSource = OrderRecordDAL.GetAllOrderRecords();

        }

        private void DgvOrderList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var cells = DgvOrderList.SelectedRows[0].Cells;
            string clientName = cells[1].Value.ToString();
            string orderId = cells[0].Value.ToString();
            MtxOrderNumber.Text = orderId;
            CbxOrderMethod.Text = cells[2].Value.ToString();

            var clients = ClientDAL.GetAllClients();

            var client = (from el in clients
                          where el.ClientName == clientName
                          select el).First();

            TbxBankAccount.Text = client.BankAccount;
            TbxPhoneNumber.Text = client.PhoneNumber;
            TbxFaxNumber.Text = client.FaxNumber;
            TbxEmail.Text = client.Email;
            TbxClientName.Text = client.ClientName;

            var orderItems = OrderItemDAL.GetAllOrderItem();
            var orderItemsFound = (from el in orderItems
                                   where el.OrderId == orderId
                                   select el).ToList();

            DgvBookItems.DataSource = orderItemsFound;
        }
    }
}
