using BookBiz_Management_System.BLL;
using BookBiz_Management_System.DAL;
using BookBiz_Management_System.GUI;

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

            //step 2: search the record matches input username 
            Employee emp = ((Employee)(from element in empList
                       where element.Username.Equals(username)
                       select element));
            //step 3: Check if the record exists, if yes, go to step 4. if no, show error message    
            if(emp != null)
            {
                //step 4: check if the password in record matches the input password, if yes, go to step 5, if no, show error message
                if(emp.Password.Equals(password))
                {
                    this.Hide();
                    //step 5: check positionId of the record and redirect to different page for different position
                    switch(emp.PositionId)
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
            else
            {
                MessageBox.Show("No employee with input username exists, please check the username");
            }
        }
    }
}