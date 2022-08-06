using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBiz_Management_System.BLL
{
    internal class Author
    {
        private string firstName { get; set; } 
        private string lastName { get; set; }  

        private string email { get; set; }

        public Author(string firstName, string lastName, string email)
        {
            this.firstName = firstName; 
            this.lastName = lastName;
            this.email = email;
        }

    }
}
