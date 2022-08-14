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
        private string firstName;
        private string lastName;
        private int groupId;

        public Employee()
        {
        }

        public Employee(int eid, string username, string password, string firstName, string lastName, int groupId)
        {
            this.eid = eid;
            this.username = username;
            this.password = password;
            this.firstName = firstName;
            this.lastName = lastName;
            this.groupId = groupId;
        }

        public int Eid { get => eid; set => eid = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int GroupId { get => groupId; set => groupId = value; }
    }
}
