using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBiz_Management_System.BLL
{
    internal class Author
    {
        private string firstName;
        private string lastName;
        private string email;

        public Author(string firstName, string lastName, string email)
        {
            this.firstName = firstName; 
            this.lastName = lastName;
            this.email = email;
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Email { get => email; set => email = value; }
    }
}
