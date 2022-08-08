using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBiz_Management_System.BLL
{
    public class Publisher
    {
        private int publisherId;
        private string publisherName;

        public Publisher() { }
        public Publisher(int publisherId, string publisherName)
        {
            this.publisherId = publisherId;
            this.publisherName = publisherName;
        }

        public int PublisherId { get => publisherId; set => publisherId = value; }
        public string PublisherName { get => publisherName; set => publisherName = value; }
    }
}
