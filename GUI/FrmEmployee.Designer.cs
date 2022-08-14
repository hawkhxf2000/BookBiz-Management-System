namespace BookBiz_Management_System.GUI
{
    partial class FrmEmployee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DgvUserGroup = new System.Windows.Forms.DataGridView();
            this.btnSearchUser = new System.Windows.Forms.Button();
            this.tbxSearchGroupName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxGroupId = new System.Windows.Forms.TextBox();
            this.lblGroupId = new System.Windows.Forms.Label();
            this.btnClearUserInfo = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.tbxGroupDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.tbxGroupName = new System.Windows.Forms.TextBox();
            this.lblGroupName = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.DgvEmployee = new System.Windows.Forms.DataGridView();
            this.BtnSearchEmployee = new System.Windows.Forms.Button();
            this.tbxSearchBy = new System.Windows.Forms.TextBox();
            this.cbxSearchBy = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TbxEid = new System.Windows.Forms.TextBox();
            this.LblUserId = new System.Windows.Forms.Label();
            this.CbxUserGroup = new System.Windows.Forms.ComboBox();
            this.btnClearEmployeeInfo = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TbxLastName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TbxFirstName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TbxPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TbxUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUserGroup)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEmployee)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(17, 16);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(816, 557);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(808, 529);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "User Group Management";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Enter += new System.EventHandler(this.TabPage1_Selected);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DgvUserGroup);
            this.groupBox2.Controls.Add(this.btnSearchUser);
            this.groupBox2.Controls.Add(this.tbxSearchGroupName);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(18, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(771, 345);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User List";
            // 
            // DgvUserGroup
            // 
            this.DgvUserGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvUserGroup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvUserGroup.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DgvUserGroup.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.DgvUserGroup.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvUserGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvUserGroup.Location = new System.Drawing.Point(-1, 67);
            this.DgvUserGroup.Name = "DgvUserGroup";
            this.DgvUserGroup.RowTemplate.Height = 25;
            this.DgvUserGroup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvUserGroup.Size = new System.Drawing.Size(772, 278);
            this.DgvUserGroup.TabIndex = 5;
            // 
            // btnSearchUser
            // 
            this.btnSearchUser.BackColor = System.Drawing.Color.LightGreen;
            this.btnSearchUser.Location = new System.Drawing.Point(606, 28);
            this.btnSearchUser.Name = "btnSearchUser";
            this.btnSearchUser.Size = new System.Drawing.Size(75, 23);
            this.btnSearchUser.TabIndex = 4;
            this.btnSearchUser.Text = "Search";
            this.btnSearchUser.UseVisualStyleBackColor = false;
            this.btnSearchUser.Click += new System.EventHandler(this.btnSearchUser_Click);
            // 
            // tbxSearchGroupName
            // 
            this.tbxSearchGroupName.Location = new System.Drawing.Point(129, 28);
            this.tbxSearchGroupName.Name = "tbxSearchGroupName";
            this.tbxSearchGroupName.Size = new System.Drawing.Size(434, 23);
            this.tbxSearchGroupName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "User Group Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxGroupId);
            this.groupBox1.Controls.Add(this.lblGroupId);
            this.groupBox1.Controls.Add(this.btnClearUserInfo);
            this.groupBox1.Controls.Add(this.btnAddUser);
            this.groupBox1.Controls.Add(this.tbxGroupDescription);
            this.groupBox1.Controls.Add(this.lblDescription);
            this.groupBox1.Controls.Add(this.tbxGroupName);
            this.groupBox1.Controls.Add(this.lblGroupName);
            this.groupBox1.Location = new System.Drawing.Point(17, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(772, 154);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Group Info";
            // 
            // tbxGroupId
            // 
            this.tbxGroupId.Location = new System.Drawing.Point(116, 27);
            this.tbxGroupId.Name = "tbxGroupId";
            this.tbxGroupId.Size = new System.Drawing.Size(136, 23);
            this.tbxGroupId.TabIndex = 7;
            // 
            // lblGroupId
            // 
            this.lblGroupId.AutoSize = true;
            this.lblGroupId.Location = new System.Drawing.Point(23, 31);
            this.lblGroupId.Name = "lblGroupId";
            this.lblGroupId.Size = new System.Drawing.Size(54, 15);
            this.lblGroupId.TabIndex = 6;
            this.lblGroupId.Text = "Group ID";
            // 
            // btnClearUserInfo
            // 
            this.btnClearUserInfo.BackColor = System.Drawing.Color.Coral;
            this.btnClearUserInfo.Location = new System.Drawing.Point(124, 113);
            this.btnClearUserInfo.Name = "btnClearUserInfo";
            this.btnClearUserInfo.Size = new System.Drawing.Size(75, 23);
            this.btnClearUserInfo.TabIndex = 5;
            this.btnClearUserInfo.Text = "Clear";
            this.btnClearUserInfo.UseVisualStyleBackColor = false;
            this.btnClearUserInfo.Click += new System.EventHandler(this.btnClearUserInfo_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.Aquamarine;
            this.btnAddUser.Location = new System.Drawing.Point(23, 113);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(75, 23);
            this.btnAddUser.TabIndex = 4;
            this.btnAddUser.Text = "Add";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // tbxGroupDescription
            // 
            this.tbxGroupDescription.Location = new System.Drawing.Point(108, 71);
            this.tbxGroupDescription.Name = "tbxGroupDescription";
            this.tbxGroupDescription.Size = new System.Drawing.Size(602, 23);
            this.tbxGroupDescription.TabIndex = 3;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(23, 75);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(67, 15);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description";
            // 
            // tbxGroupName
            // 
            this.tbxGroupName.Location = new System.Drawing.Point(434, 27);
            this.tbxGroupName.Name = "tbxGroupName";
            this.tbxGroupName.Size = new System.Drawing.Size(276, 23);
            this.tbxGroupName.TabIndex = 1;
            // 
            // lblGroupName
            // 
            this.lblGroupName.AutoSize = true;
            this.lblGroupName.Location = new System.Drawing.Point(341, 31);
            this.lblGroupName.Name = "lblGroupName";
            this.lblGroupName.Size = new System.Drawing.Size(75, 15);
            this.lblGroupName.TabIndex = 0;
            this.lblGroupName.Text = "Group Name";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(808, 529);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Employee Management";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Enter += new System.EventHandler(this.TabPage2_Selected);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.DgvEmployee);
            this.groupBox4.Controls.Add(this.BtnSearchEmployee);
            this.groupBox4.Controls.Add(this.tbxSearchBy);
            this.groupBox4.Controls.Add(this.cbxSearchBy);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(4, 175);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(798, 352);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Employee List";
            // 
            // DgvEmployee
            // 
            this.DgvEmployee.AllowUserToAddRows = false;
            this.DgvEmployee.AllowUserToDeleteRows = false;
            this.DgvEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvEmployee.Location = new System.Drawing.Point(0, 74);
            this.DgvEmployee.MultiSelect = false;
            this.DgvEmployee.Name = "DgvEmployee";
            this.DgvEmployee.RowTemplate.Height = 25;
            this.DgvEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvEmployee.Size = new System.Drawing.Size(798, 277);
            this.DgvEmployee.TabIndex = 5;
            this.DgvEmployee.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TableCell_DoubleClick);
            // 
            // BtnSearchEmployee
            // 
            this.BtnSearchEmployee.BackColor = System.Drawing.Color.LightGreen;
            this.BtnSearchEmployee.Location = new System.Drawing.Point(652, 26);
            this.BtnSearchEmployee.Name = "BtnSearchEmployee";
            this.BtnSearchEmployee.Size = new System.Drawing.Size(75, 23);
            this.BtnSearchEmployee.TabIndex = 4;
            this.BtnSearchEmployee.Text = "Search";
            this.BtnSearchEmployee.UseVisualStyleBackColor = false;
            this.BtnSearchEmployee.Click += new System.EventHandler(this.BtnSearchEmployee_Click);
            // 
            // tbxSearchBy
            // 
            this.tbxSearchBy.Location = new System.Drawing.Point(233, 26);
            this.tbxSearchBy.Name = "tbxSearchBy";
            this.tbxSearchBy.Size = new System.Drawing.Size(377, 23);
            this.tbxSearchBy.TabIndex = 6;
            // 
            // cbxSearchBy
            // 
            this.cbxSearchBy.FormattingEnabled = true;
            this.cbxSearchBy.Items.AddRange(new object[] {
            "ID",
            "First Name",
            "Last Name"});
            this.cbxSearchBy.Location = new System.Drawing.Point(84, 26);
            this.cbxSearchBy.Name = "cbxSearchBy";
            this.cbxSearchBy.Size = new System.Drawing.Size(127, 23);
            this.cbxSearchBy.TabIndex = 2;
            this.cbxSearchBy.Text = "ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Search by";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TbxEid);
            this.groupBox3.Controls.Add(this.LblUserId);
            this.groupBox3.Controls.Add(this.CbxUserGroup);
            this.groupBox3.Controls.Add(this.btnClearEmployeeInfo);
            this.groupBox3.Controls.Add(this.btnAddEmployee);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.TbxLastName);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.TbxFirstName);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.TbxPassword);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.TbxUsername);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(798, 163);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Employee Info";
            // 
            // TbxEid
            // 
            this.TbxEid.AcceptsTab = true;
            this.TbxEid.Location = new System.Drawing.Point(84, 30);
            this.TbxEid.Name = "TbxEid";
            this.TbxEid.Size = new System.Drawing.Size(147, 23);
            this.TbxEid.TabIndex = 1;
            // 
            // LblUserId
            // 
            this.LblUserId.AutoSize = true;
            this.LblUserId.Location = new System.Drawing.Point(5, 34);
            this.LblUserId.Name = "LblUserId";
            this.LblUserId.Size = new System.Drawing.Size(73, 15);
            this.LblUserId.TabIndex = 13;
            this.LblUserId.Text = "Employee ID";
            // 
            // CbxUserGroup
            // 
            this.CbxUserGroup.FormattingEnabled = true;
            this.CbxUserGroup.Location = new System.Drawing.Point(570, 80);
            this.CbxUserGroup.Name = "CbxUserGroup";
            this.CbxUserGroup.Size = new System.Drawing.Size(157, 23);
            this.CbxUserGroup.TabIndex = 12;
            // 
            // btnClearEmployeeInfo
            // 
            this.btnClearEmployeeInfo.BackColor = System.Drawing.Color.Coral;
            this.btnClearEmployeeInfo.Location = new System.Drawing.Point(636, 119);
            this.btnClearEmployeeInfo.Name = "btnClearEmployeeInfo";
            this.btnClearEmployeeInfo.Size = new System.Drawing.Size(75, 23);
            this.btnClearEmployeeInfo.TabIndex = 11;
            this.btnClearEmployeeInfo.Text = "Clear";
            this.btnClearEmployeeInfo.UseVisualStyleBackColor = false;
            this.btnClearEmployeeInfo.Click += new System.EventHandler(this.btnClearEmployeeInfo_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BackColor = System.Drawing.Color.Aquamarine;
            this.btnAddEmployee.Location = new System.Drawing.Point(535, 119);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(75, 23);
            this.btnAddEmployee.TabIndex = 10;
            this.btnAddEmployee.Text = "Add";
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(498, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "User Group";
            // 
            // TbxLastName
            // 
            this.TbxLastName.AcceptsTab = true;
            this.TbxLastName.Location = new System.Drawing.Point(324, 80);
            this.TbxLastName.Name = "TbxLastName";
            this.TbxLastName.Size = new System.Drawing.Size(147, 23);
            this.TbxLastName.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(254, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Last Name";
            // 
            // TbxFirstName
            // 
            this.TbxFirstName.AcceptsTab = true;
            this.TbxFirstName.Location = new System.Drawing.Point(84, 80);
            this.TbxFirstName.Name = "TbxFirstName";
            this.TbxFirstName.Size = new System.Drawing.Size(147, 23);
            this.TbxFirstName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "First Name";
            // 
            // TbxPassword
            // 
            this.TbxPassword.AcceptsTab = true;
            this.TbxPassword.Location = new System.Drawing.Point(565, 30);
            this.TbxPassword.Name = "TbxPassword";
            this.TbxPassword.Size = new System.Drawing.Size(162, 23);
            this.TbxPassword.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(501, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // TbxUsername
            // 
            this.TbxUsername.AcceptsTab = true;
            this.TbxUsername.Location = new System.Drawing.Point(325, 30);
            this.TbxUsername.Name = "TbxUsername";
            this.TbxUsername.Size = new System.Drawing.Size(147, 23);
            this.TbxUsername.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username";
            // 
            // FrmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 597);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmEmployee";
            this.Text = "Employee Management";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUserGroup)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEmployee)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox groupBox1;
        private Label lblGroupName;
        private GroupBox groupBox2;
        private Button btnSearchUser;
        private TextBox tbxSearchGroupName;
        private Label label1;
        private Button btnAddUser;
        private TextBox tbxGroupDescription;
        private Label lblDescription;
        private TextBox tbxGroupName;
        private GroupBox groupBox3;
        private TextBox TbxUsername;
        private Label label2;
        private TextBox TbxFirstName;
        private Label label4;
        private TextBox TbxPassword;
        private Label label3;
        private Button btnClearUserInfo;
        private GroupBox groupBox4;
        private Button BtnSearchEmployee;
        private TextBox tbxSearchBy;
        private ComboBox cbxSearchBy;
        private Label label7;
        private ComboBox CbxUserGroup;
        private Button btnClearEmployeeInfo;
        private Button btnAddEmployee;
        private Label label6;
        private TextBox TbxLastName;
        private Label label5;
        private DataGridView DgvUserGroup;
        private TextBox tbxGroupId;
        private Label lblGroupId;
        private TextBox TbxUserId;
        private Label LblUserId;
        private TextBox TbxEid;
        private DataGridView DgvEmployee;
    }
}