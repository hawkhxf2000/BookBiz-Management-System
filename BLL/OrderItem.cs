using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBiz_Management_System.BLL
{
    public class OrderItem
    {
        private string? orderId;
        private string? iSBN;
        private string? title;
        private int quantity;

        public OrderItem() { }

        public OrderItem(string? orderId, string? iSBN, string title, int quantity)
        {
            this.orderId = orderId;
            this.iSBN = iSBN;
            this.title = title;
            this.quantity = quantity;
        }

        public string? OrderId { get => orderId; set => orderId = value; }
        public string? ISBN { get => iSBN; set => iSBN = value; }
        public string? Title { get => title; set => title = value; }
        public int Quantity { get => quantity; set => quantity = value; }
    }
}
