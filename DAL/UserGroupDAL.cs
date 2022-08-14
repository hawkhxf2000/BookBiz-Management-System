using BookBiz_Management_System.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBiz_Management_System.DAL
{
    public static class UserGroupDAL
    {
        private static string filePath = Application.StartupPath + @"\data\UserGroup.dat";  //data source

        //1. add a record to Employee.dat file
        public static void AddUserGroup(UserGroup group)
        {
            StreamWriter sWriter = new StreamWriter(filePath, true);
            sWriter.WriteLine(group.GroupId + "," + group.GroupName + "," + group.Description);
            sWriter.Close();
            //MessageBox.Show("new User Group has been saved.");

        }

        //get all UserGroups records from file
        public static List<UserGroup> GetAllUserGroups()
        {
            List<UserGroup> listG = new List<UserGroup>();
            //step 1: Create an object of type StreamReader
            StreamReader sReader = new StreamReader(filePath);
            // Step 2: Read the file until the end of the file
        
            string? line = sReader.ReadLine();
            while (line != null)
            {
                string[] fields = line.Split(',');
                UserGroup group = new UserGroup();
                group.GroupId = Convert.ToInt32(fields[0]);
                group.GroupName = fields[1];
                group.Description = fields[2];
                listG.Add(group);
                line = sReader.ReadLine();
            }
            sReader.Close(); //Close the file
            return listG;
        }

        //Get UserGroup record by name
        public static List<UserGroup>? GetUserGroupByName(string groupName)
        {
            //step 1: get all records where name in records match input name
            List<UserGroup> listG = GetAllUserGroups();
            List<UserGroup> groups = (from element in listG
                            where element.GroupName == groupName
                            select element).ToList();
            if (groups != null)
            {
                return groups;
            }
            else
            {
                MessageBox.Show("There is no employee with this id");
                return null;
            }
        }

    }
}
