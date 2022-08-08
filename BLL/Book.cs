using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBiz_Management_System.BLL
{
    public class Book
    {
        private string ISBN;
        private string title;
        private float unitPrice;
        private int QOH;
        private string publishYear;
        private int publisherId;
        private string authors;

        public Book() { }
        public Book(string iSBN, string title, float unitPrice, int qOH, string publishYear, int publisherId, string authors)
        {
            ISBN = iSBN;
            this.title = title;
            this.unitPrice = unitPrice;
            QOH = qOH;
            this.publishYear = publishYear;
            this.publisherId = publisherId;
            this.authors = authors;
        }

        public string ISBN1 { get => ISBN; set => ISBN = value; }
        public string Title { get => title; set => title = value; }
        public float UnitPrice { get => unitPrice; set => unitPrice = value; }
        public int QOH1 { get => QOH; set => QOH = value; }
        public string PublishYear { get => publishYear; set => publishYear = value; }
        public int PublisherId { get => publisherId; set => publisherId = value; }
        public string Authors { get => authors; set => authors = value; }

        enum category
        {
            Artificial_intelligence,
            cyber_security,
            computer_system,
            graphic_design,
            software_engineering,
            numerical_analysis,
            database_system
        }
    }
}
