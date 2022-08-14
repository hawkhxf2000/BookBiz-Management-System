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
        private static string filePath = Application.StartupPath + @"\data\Employees.dat";  //data source

        //1. add a record to Employee.dat file
        public static void AddEmployee(Employee emp)
        {
            StreamWriter sWriter = new StreamWriter(filePath, true);
            sWriter.WriteLine(emp.Eid + "," + emp.Username + "," + emp.Password + "," + emp.FirstName+"," + emp.LastName+"," + emp.GroupId);
            sWriter.Close();
            MessageBox.Show("Employee Data has been saved.");

        }

        //get all Employee records from file
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

            string? line = sReader.ReadLine();
            while (line != null)
            {
                string[] fields = line.Split(',');
                Employee emp = new Employee();
                emp.Eid = Convert.ToInt32(fields[0]);
                emp.Username = fields[1];
                emp.Password = fields[2];
                emp.FirstName = fields[3];
                emp.LastName = fields[4];
                emp.GroupId = Convert.ToInt32(fields[5]);
                listE.Add(emp);
                line = sReader.ReadLine();
            }
            sReader.Close(); //Close the file
            return listE;
        }

        //Get employee record by id
        public static Employee? GetEmployeeById(int eid)
        {
            //step 1: get all records where name in records match input name
            List<Employee> listE = GetAllEmployees();
            Employee emp = (from element in listE
                           where element.Eid == eid
                           select element).ToList()[0];
            if (emp != null)
            {
                return emp;
            }
            else
            {
                MessageBox.Show("There is no employee with this id");
                return null;
            }
        }

        //Get Employee record dynamically
        public static List<Employee>? GetEmployeesDync(int eid, string firstname, string lastname)
        {
            List<Employee> listE = GetAllEmployees();
            List<Employee> employees = (from element in listE
                                     where (element.Eid == eid ||
                                                    element.FirstName.ToLower()==firstname.ToLower() ||
                                                    element.LastName.ToLower()==lastname.ToLower())       
                                     select element).ToList();
            if (employees != null)
            {
                return employees;
            }
            else
            {
                MessageBox.Show("There is no employee with this id");
                return null;
            }
        }

    }
}
