using BookBiz_Management_System.BLL;
using BookBiz_Management_System.DAL;
using BookBiz_Management_System.Utils;
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
    public partial class FrmClient : Form
    {
        private List<Client> clients = new List<Client>();
        public FrmClient()
        {
            InitializeComponent();
            clients = ClientDAL.GetAllClients();
            ShowClients(clients);   
        }

        //global method for Showing Clients List
        private void ShowClients(List<Client> clients)
        {
            DgvClients.DataSource = clients;
        }

        //global method for clear all input fields
        private void ClearAll()
        {
            TbxClientId.Clear();
            TbxClientName.Clear();
            MtxPhoneNumber.Clear();
            MtxBankAccount.Clear();
            TbxEmail.Clear();
            TbxAddress.Clear();
            MtxPostalCode.Clear();
            MtxFaxNumber.Clear();
            TbxCreditLimit.Clear();
        }

        
        private void BtnAddClient_Click(object sender, EventArgs e)
        {
            //step 1: assign input value to variables
            int clientId = Convert.ToInt32(TbxClientId.Text);
            string clientName = TbxClientName.Text;
            string phoneNumber = MtxPhoneNumber.Text;
            string faxNumber = MtxFaxNumber.Text;
            string email = TbxEmail.Text;
            string address = TbxAddress.Text;
            string postalCode = MtxPostalCode.Text;
            string bankAccount = MtxBankAccount.Text;
            decimal creditLimit = Convert.ToDecimal(TbxCreditLimit.Text);

            //step 2: verify variables
            //verify if not null
            if(clientId == 0 || clientName == null || phoneNumber == null || faxNumber == null || address == null || postalCode == null
                || bankAccount == null || creditLimit == 0)
            {
                MessageBox.Show("All the fields must not be empty!");
                return;
            }
            //verify if client ID has only number
            if (!VerificationUtil.VerifyNumber(TbxClientId.Text))
            {
                MessageBox.Show("Client ID must be number only");
                return ;
            }
            //verify if client name contains number
            if (clientName.Contains(@"[0-9]")){
                MessageBox.Show("Client name should not contain numbers, please double check it!");
                return;
            }

            //step 3: create a client object with variables and save it to file
            Client client = new Client(clientId, clientName, phoneNumber, faxNumber, email, address, postalCode, bankAccount, creditLimit);
            ClientDAL.SaveClient(client);
            ShowClients(ClientDAL.GetAllClients());
            ClearAll();
            
        }

        private void BtnClearClientInfo_Click(object sender, EventArgs e)
        {
           ClearAll();
        }

        private void BtnSearchClient_Click(object sender, EventArgs e)
        {
            //Step 1: initialize each search criteria
            int clientId = 0;
            string clientName = "";
            string phoneNumber = "";
            string faxNumber = "";
            string numberTemp = "";

            //step 2: check if textbox of search has no input, if yes, list all clients
            if(TbxSearchBy.Text == "")
            {
                DgvClients.DataSource = ClientDAL.GetAllClients();
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
                    clientId = Convert.ToInt32(TbxSearchBy.Text);
                    break;
                case 1:
                    clientName = TbxSearchBy.Text;
                    break;
                case 2:
                    numberTemp = Regex.Replace(TbxSearchBy.Text, @"[^0-9]+", ""); //remove all non-numeric character
                    phoneNumber = numberTemp.Substring(0,3) + "-" + numberTemp.Substring(3,3) + "-" + numberTemp.Substring(6,4);
                    break;
                case 3:
                    numberTemp = Regex.Replace(TbxSearchBy.Text, @"[^0-9]+", ""); ////remove all non-numeric character
                    faxNumber = numberTemp.Substring(0, 3) + "-" + numberTemp.Substring(3, 3) + "-" + numberTemp.Substring(6, 4);
                    break;
                default:
                    break;
            }

            //step 4: Get list of client by selected search criteria
            List<Client> clientsFound = ClientDAL.GetClientsDync(clientId, clientName, phoneNumber, faxNumber);

            //step 5: Show result on the page
            DgvClients.DataSource = clientsFound;
        }

        private void DgvItem_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //step 1: obtain the cells of select item in table 
            var selectedCells = DgvClients.SelectedRows[0].Cells;

            //step 2: display the cells to corresponding fields of client information
            TbxClientId.Text = selectedCells[0].Value.ToString();
            TbxClientName.Text = selectedCells[1].Value.ToString();
            MtxPhoneNumber.Text = selectedCells[4].Value.ToString();
            MtxFaxNumber.Text = selectedCells[5].Value.ToString();
            TbxEmail.Text = selectedCells[8].Value.ToString();
            TbxAddress.Text = selectedCells[2].Value.ToString();
            MtxPostalCode.Text = selectedCells[3].Value.ToString();
            MtxBankAccount.Text = selectedCells[6].Value.ToString();
            TbxCreditLimit.Text = selectedCells[7].Value.ToString();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
           int clientId = Convert.ToInt32(TbxClientId.Text);
           string clientName = TbxClientName.Text;
           string phoneNumber = MtxPhoneNumber.Text;
            string faxNumber = MtxFaxNumber.Text;
            string email = TbxEmail.Text;
            string address = TbxAddress.Text;
            string postalCode = MtxPostalCode.Text;
            string bankAccount = MtxBankAccount.Text;
            decimal creditLimit = Convert.ToDecimal(TbxCreditLimit.Text);

            var client = new Client(clientId, clientName, phoneNumber, faxNumber, email, address, postalCode, bankAccount, creditLimit);

            ClientDAL.UpdateClient(client);

            var clients = ClientDAL.GetAllClients().OrderBy(c => c.ClientId).ToList();
            DgvClients.DataSource = clients;
        }
    }
}
