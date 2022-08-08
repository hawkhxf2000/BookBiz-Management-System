using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBiz_Management_System.BLL
{
    public class OrderRecord
    {
        private int orderNo;
        private string clientName;

        public OrderRecord() { }

        public OrderRecord(int orderNo, string clientName)
        {
            this.orderNo = orderNo;
            this.clientName = clientName;
        }

        public int OrderNo { get => orderNo; set => orderNo = value; }
        public string ClientName { get => clientName; set => clientName = value; }

        enum orderMethod 
        {
            phone,
            fax,
            Email
        }

    }
}
