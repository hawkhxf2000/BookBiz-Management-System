using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBiz_Management_System.BLL
{
    public class OrderItem
    {
        private int orderId;
        private string ISBN;

        public OrderItem(int orderId, string iSBN)
        {
            this.orderId = orderId;
            ISBN = iSBN;
        }

        public int OrderId { get => orderId; set => orderId = value; }
        public string ISBN1 { get => ISBN; set => ISBN = value; }
    }
}
