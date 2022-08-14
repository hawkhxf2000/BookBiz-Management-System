using BookBiz_Management_System.BLL;
using BookBiz_Management_System.DAL;
using BookBiz_Management_System.GUI;
using System.Linq;

namespace BookBiz_Management_System
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        List<Employee> empList = EmployeeDAL.GetAllEmployees();
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {   
            //Step 1: get input username and password
            string username = tbx_username.Text;
            string password = tbx_password.Text;
           

            //step 2: search the record matches input username, check the count of records, if it's not 1, show error message, otherwise go to step 3 
            List<Employee> empListTemp = (from element in empList
                                       where element.Username == username
                                       select element).ToList();
           
            

            //step 3: Check if the record exists, if yes, go to step 4. if no, show error message    
            if (empListTemp.Count() == 1)
            {
                //step 4: check if the password in record matches the input password, if yes, go to step 5, otherwise show error message
                Employee emp = empListTemp[0];
                if (emp.Password.Equals(password))
                {
                    this.Hide();
                    //step 5: check positionId of the record and redirect to different page for different position
                    switch (emp.GroupId)
                    {
                        //redirect to MIS Manager
                        case 0:
                            FrmEmployee frmEmployee = new FrmEmployee();
                            frmEmployee.Show();
                            break;
                        //redirect to Sales Manager
                        case 1:
                            FrmClient frmClient = new FrmClient();
                            frmClient.Show();
                            break;
                        //redirect to Inventory Controller
                        case 2:
                            FrmBook frmBook = new FrmBook();
                            frmBook.Show();
                            break;
                        //redirect to Order Clerks
                        case 3:

                            FrmOrder frmOrder = new FrmOrder();
                            frmOrder.Show();
                            break;
                        default:
                            MessageBox.Show("There is no such a position");
                            break;


                    }
                }
                else
                {
                    MessageBox.Show("Password does not matched, please check the password");
                }
            }
            else if(empListTemp.Count() == 0)
            {
                MessageBox.Show("No employee with input username exists, please check the username");
            }
            else
            {
                MessageBox.Show("There are more than 1 user has the same username, please check the user List");
            }
        }
    }
}