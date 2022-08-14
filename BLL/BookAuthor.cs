using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBiz_Management_System.BLL
{
    public class BookAuthor
    {
        private string iSBN;
        private int authorId;

        public BookAuthor() { }

        public BookAuthor(string iSBN, int authorId)
        {
            this.iSBN = iSBN;
            this.authorId = authorId;
        }

        public string ISBN { get => iSBN; set => iSBN = value; }
        public int AuthorId { get => authorId; set => authorId = value; }
    }
}
