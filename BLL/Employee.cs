using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBiz_Management_System.BLL
{
    public class Employee
    {
        private int eid;
        private string username;
        private string password;
        private int positionId;

        public Employee()
        {
        }

        public Employee(int eid, string username, string password, int positionId)
        {
            this.eid = eid;
            this.username = username;
            this.password = password;
            this.positionId = positionId;  //0 - MIS Manager, 1 - sales Manager, 2 - Inventory Controller, 3 - Order Clerks
        }

        public int Eid { get => eid; set => eid = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public int PositionId { get => positionId; set => positionId = value; }
    }
}
