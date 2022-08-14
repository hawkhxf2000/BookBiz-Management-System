using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBiz_Management_System.BLL
{
    public class OrderRecord
    {
        private static int count = 1; //use static variable to assign eid auto-increment
        private int orderId;
        private string? clientName;

        public OrderRecord() { this.orderId = count++; }

        public OrderRecord(string clientName)
        {
            this.orderId = count++;
            this.clientName = clientName;
        }

        public int OrderId { get => orderId; set => orderId = value; }
        public string ClientName { get => clientName; set => clientName = value; }

        enum orderMethod 
        {
            phone,
            fax,
            Email
        }

    }
}
