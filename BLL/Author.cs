using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBiz_Management_System.BLL
{
    public class Author
    {
        private int authorId;
        private string firstName;
        private string lastName;
        private string email;

        public Author() { }

        public Author(int authorId, string firstName, string lastName, string email)
        {
            this.authorId = authorId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
        }

        public int AuthorId { get => authorId; set => authorId = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Email { get => email; set => email = value; }
    }
}
