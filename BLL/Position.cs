using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBiz_Management_System.BLL
{
    public class Position
    {
        private int positionId;
        private string positionName;
        private string description;

        public Position() { }
        public Position(int positionId, string positionName, string description)
        {
            this.positionId = positionId;
            this.positionName = positionName;
            this.description = description;
        }

        public int PositionId { get => positionId; set => positionId = value; }
        public string PositionName { get => positionName; set => positionName = value; }
        public string Description { get => description; set => description = value; }
    }
}
