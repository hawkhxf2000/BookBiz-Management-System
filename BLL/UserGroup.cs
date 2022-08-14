using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBiz_Management_System.BLL
{
    public class UserGroup
    {
        private int groupId;
        private string groupName;
        private string description;

        public UserGroup() { }
        public UserGroup(int groupId, string groupName, string description)
        {
            this.groupId = groupId;
            this.groupName = groupName;
            this.description = description;
        }

        public int GroupId { get => groupId; set => groupId = value; }
        public string GroupName { get => groupName; set => groupName = value; }
        public string Description { get => description; set => description = value; }
    }
}
