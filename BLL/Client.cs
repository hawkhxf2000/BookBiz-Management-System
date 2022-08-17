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
        private string email;
        private string bankAccount;
        private decimal creditLimit;

        public Client() { }

        public Client(int clientId, string clientName, string phoneNumber, string faxNumber, string email, string? address, string? postalCode,  string bankAccount, decimal creditLimit)
        {
            this.clientId = clientId;
            this.clientName = clientName;
            this.address = address;
            this.postalCode = postalCode;
            this.phoneNumber = phoneNumber;
            this.faxNumber = faxNumber;
            this.email = email;
            this.bankAccount = bankAccount;
            this.creditLimit = creditLimit;
        }

        public int ClientId { get => clientId; set => clientId = value; }
        public string ClientName { get => clientName; set => clientName = value; }
        public string? Address { get => address; set => address = value; }
        public string? PostalCode { get => postalCode; set => postalCode = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string FaxNumber { get => faxNumber; set => faxNumber = value; }
        public string BankAccount { get => bankAccount; set => bankAccount = value; }
        public decimal CreditLimit { get => creditLimit; set => creditLimit = value; }
        public string Email { get => email; set => email = value; }
    }
}
