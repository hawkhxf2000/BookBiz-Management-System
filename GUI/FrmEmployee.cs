using BookBiz_Management_System.BLL;
using BookBiz_Management_System.DAL;
using BookBiz_Management_System.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookBiz_Management_System.GUI
{
    public partial class FrmEmployee : Form
    {
        private List<UserGroup> groups = new List<UserGroup>();
        private List<Employee> employees = new List<Employee>();
        public FrmEmployee()
        {
            InitializeComponent();
            groups = UserGroupDAL.GetAllUserGroups();
            employees = EmployeeDAL.GetAllEmployees();
            DgvUserGroup.DataSource =groups;
        }

        private void TabPage1_Selected(object sender, EventArgs e)
        {
            DgvUserGroup.DataSource = groups;
        }
        private void TabPage2_Selected(object sender, EventArgs e)
        {
            DgvEmployee.DataSource = employees;
            List<string> groupNames = new List<string>();
            groups.ForEach(group => groupNames.Add(group.GroupName));
            CbxUserGroup.DataSource = groupNames;
        }

        private void ClearEmployeeInfo()
        {
            TbxEid.Clear();
            TbxUsername.Clear();
            TbxPassword.Clear();
            TbxFirstName.Clear();  
            TbxLastName.Clear();
            CbxUserGroup.SelectedIndex = -1;
        }
        private void DgvUserGroup_load(object sender, EventArgs e)
        {
        }
        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            //verification of group ID and name
            if (!VerificationUtil.VerifyNumber(this.tbxGroupId.Text))
            {
                MessageBox.Show("Group Id must be numbers, please check it again!");
                tbxGroupId.Focus();
                return;
            }
            if (!VerificationUtil.VerifyLetter(this.tbxGroupName.Text))
            {
                MessageBox.Show("Group name must be letters, please check it again!");
                tbxGroupName.Focus();
                return;
            }

            //Assign the text in textboxes to variables
            int groupId =Convert.ToInt32(this.tbxGroupId.Text);
            String groupName = this.tbxGroupName.Text;
            String description = this.tbxGroupDescription.Text;

            //add new UserGroup
            UserGroupDAL.AddUserGroup(new UserGroup(groupId, groupName, description));
            DgvUserGroup.DataSource = UserGroupDAL.GetAllUserGroups();
            Clear();
        }

        private void btnClearUserInfo_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            String groupName = this.tbxSearchGroupName.Text;
            List<UserGroup>? groups = UserGroupDAL.GetUserGroupByName(groupName);
            DgvUserGroup.DataSource = groups;
        }

        internal void Clear()
        {
            this.tbxGroupName.Text = "";
            this.tbxGroupDescription.Text = "";
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            //Assign the text in textboxes to variables
            int eId = Convert.ToInt32(this.TbxEid.Text);
            string username = this.TbxUsername.Text;
            string password = this.TbxPassword.Text;
            string firstName = this.TbxFirstName.Text;
            string lastName = this.TbxLastName.Text;
            int groupId = this.CbxUserGroup.SelectedIndex;
            //verify if all fields are not null
            if(eId == 0 || username == null || password == null || firstName == null || lastName == null)
            {
                MessageBox.Show("All fields must have value, please check again!");
                return;
            }
            //verification of group ID, first name, last name
            if (!VerificationUtil.VerifyNumber(this.TbxEid.Text))
            {
                MessageBox.Show("User Id must be numbers, please check it again!");
                TbxUserId.Focus();
                return;
            }
            if (!VerificationUtil.VerifyLetter(firstName))
            {
                MessageBox.Show("First name must be letters, please check it again!");
                TbxFirstName.Focus();
                return;
            }
            if (!VerificationUtil.VerifyLetter(lastName))
            {
                MessageBox.Show("Last name must be letters, please check it again!");
                TbxLastName.Focus();
                return;
            }

            //Verify if username is unique
            List<Employee> employees = EmployeeDAL.GetAllEmployees();
            employees.ForEach(emp =>
            {
                if (emp.Username == username)
                {
                    MessageBox.Show("The username has already existed, please input another one!");
                    TbxUsername.Focus();
                    return;
                }
            });
            //add new UserGroup
            EmployeeDAL.AddEmployee(new Employee(eId, username, password, firstName, lastName, groupId));
            DgvEmployee.DataSource = EmployeeDAL.GetAllEmployees();
            Clear();
        }

        private void BtnSearchEmployee_Click(object sender, EventArgs e)
        {
            // step 1: set initial value for each parameter
            int eid = 0;
            string firstName = "";
            string lastName = ""; 
            //step 2: get combobox index to determine search criteria
            int criteria = this.cbxSearchBy.SelectedIndex;
            //step 3: get textbox value and set it to selected criteria
            switch (criteria)
            {
                case 0:
                    eid = Convert.ToInt32(tbxSearchBy.Text);
                    break;
                case 1:
                    firstName = tbxSearchBy.Text;
                    break;
                case 2:
                    lastName = tbxSearchBy.Text;
                    break;
                default:
                    break;
            }
            //step 4: pass parameters to DAL Search method and get a list of result
            var employees = EmployeeDAL.GetEmployeesDync(eid, firstName, lastName);
            //step 5: show the list of result onto datagridview
            DgvEmployee.DataSource = employees;
        }

        private void TableCell_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //step 1: Obtain the eid of selected record from table of employee
            string? valueSelected = DgvEmployee.SelectedRows[0].Cells[0].Value.ToString();
            int eidSelected = Convert.ToInt32(valueSelected);

            //step 2: get employee object from selected eid;
            var employeefound = EmployeeDAL.GetEmployeeById(eidSelected);

            //Display employee found on textboxes of information
            TbxEid.Text = employeefound.Eid.ToString();
            TbxUsername.Text = employeefound.Username.ToString();
            TbxPassword.Text = employeefound.Password.ToString();
            TbxFirstName.Text = employeefound.FirstName.ToString();
            TbxLastName.Text = employeefound.LastName.ToString();
            CbxUserGroup.SelectedItem = employeefound.GroupId;
        }

        private void btnClearEmployeeInfo_Click(object sender, EventArgs e)
        {
            ClearEmployeeInfo();
        }
    }
}
