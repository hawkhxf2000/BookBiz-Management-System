using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBiz_Management_System.BLL
{
    public class Client
    {
        private int clientId;
        private string clientName;
        private string? address;
        private string? postalCode;
        private string phoneNumber;
        private string faxNumber;
        private string bankAccount;
        private int credit_limit;

        public Client() { }

        public Client(int clientId, string clientName, string? address, string? postalCode, string phoneNumber, string faxNumber, string bankAccount, int credit_limit)
        {
            this.clientId = clientId;
            this.clientName = clientName;
            this.address = address;
            this.postalCode = postalCode;
            this.phoneNumber = phoneNumber;
            this.faxNumber = faxNumber;
            this.bankAccount = bankAccount;
            this.credit_limit = credit_limit;
        }

        public int ClientId { get => clientId; set => clientId = value; }
        public string ClientName { get => clientName; set => clientName = value; }
        public string? Address { get => address; set => address = value; }
        public string? PostalCode { get => postalCode; set => postalCode = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string FaxNumber { get => faxNumber; set => faxNumber = value; }
        public string BankAccount { get => bankAccount; set => bankAccount = value; }
        public int Credit_limit { get => credit_limit; set => credit_limit = value; }
    }
}
