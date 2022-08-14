using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBiz_Management_System.BLL
{
    public class Book
    {
        private string? iSBN;
        private string? title;
        private decimal unitPrice;
        private int qOH;
        private string? category;
        private string? publishYear;
        private string? publisherName;
        private string? authors;
        

        public Book() { }

        public Book(string iSBN, string title, decimal unitPrice, int qOH, string category, string publishYear, string publisherName, string authors)
        {
            this.iSBN = iSBN;
            this.title = title;
            this.unitPrice = unitPrice;
            this.qOH = qOH;
            this.category = category;
            this.publishYear = publishYear;
            this.publisherName = publisherName;
            this.authors = authors;
        }

        public string ISBN { get => iSBN; set => iSBN = value; }
        public string Title { get => title; set => title = value; }
        public decimal UnitPrice { get => unitPrice; set => unitPrice = value; }
        public int QOH { get => qOH; set => qOH = value; }
        public string Category { get => category; set => category = value; }
        public string PublishYear { get => publishYear; set => publishYear = value; }
        public string PublisherName { get => publisherName; set => publisherName = value; }
        public string Authors { get => authors; set => authors = value; }
    }
}
