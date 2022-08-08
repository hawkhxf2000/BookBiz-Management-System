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
        private string name;
        private string email;

        public Author() { }

        public Author(int authorId, string name, string email)
        {
            this.authorId = authorId;
            this.name = name;
            this.email = email;
        }

        public int AuthorId { get => authorId; set => authorId = value; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
    }
}
