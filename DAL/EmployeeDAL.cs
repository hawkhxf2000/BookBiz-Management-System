using BookBiz_Management_System.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBiz_Management_System.DAL
{
    public static class EmployeeDAL
    {
        private static string filePath = Application.StartupPath + @"\Employees.dat";
        private static string fileTemp = Application.StartupPath + @"\Temp.dat";

        public static void SaveEmployee(Employee emp)
        {
            StreamWriter sWriter = new StreamWriter(filePath, true);
            sWriter.WriteLine(emp.Eid + "," + emp.Username + "," + emp.Password + "," + emp.PositionId);
            sWriter.Close();
            MessageBox.Show("Employee Data has been saved.");

        }
        public static List<Employee> GetAllEmployees()
        {
            List<Employee> listE = new List<Employee>();
            //step 1: Create an object of type StreamReader
            StreamReader sReader = new StreamReader(filePath);
            // Step 2: Read the file until teh end of the file
            //         - Read line by line
            //         - Split the line into an array of string based on seperator
            //         - Create an object of type Customer
            //         -Store data in the object Customer
            //         -Add the object to the listC
            //         -Close the file : VERY IMPORTANT

            string line = sReader.ReadLine();
            while (line != null)
            {
                string[] fields = line.Split(',');
                Employee emp = new Employee();
                emp.Eid = Convert.ToInt32(fields[0]);
                emp.Username = fields[1];
                emp.Password = fields[2];
                emp.PositionId = Convert.ToInt32(fields[0]);
                listE.Add(emp);
                line = sReader.ReadLine();
            }
            sReader.Close(); //Close the file
            return listE;
        }


    }
}
