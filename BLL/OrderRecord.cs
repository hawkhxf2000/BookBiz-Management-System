using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBiz_Management_System.BLL
{
    public class OrderRecord
    {
        private string orderId;
        private string? clientName;
        private string orderMethod;
        //private string orderItems;

        public OrderRecord() { }

        public OrderRecord(string orderId, string? clientName, string orderMethod)
        {
            this.orderId = orderId;
            this.clientName = clientName;
            this.orderMethod = orderMethod;
            //this.orderItems = orderItems;
        }

        public string OrderId { get => orderId; set => orderId = value; }
        public string? ClientName { get => clientName; set => clientName = value; }
        public string OrderMethod { get => orderMethod; set => orderMethod = value; }
        //public string OrderItems { get => orderItems; set => orderItems = value; }
    }
}
