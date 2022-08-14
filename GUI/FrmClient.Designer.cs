namespace BookBiz_Management_System.GUI
{
    partial class FrmClient
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MtxBankAccount = new System.Windows.Forms.MaskedTextBox();
            this.TbxEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TbxCreditLimit = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnClearClientInfo = new System.Windows.Forms.Button();
            this.BtnAddClient = new System.Windows.Forms.Button();
            this.MtxFaxNumber = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.MtxPostalCode = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TbxAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MtxPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TbxClientName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TbxClientId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DgvClients = new System.Windows.Forms.DataGridView();
            this.BtnSearchClient = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.TbxSearchBy = new System.Windows.Forms.TextBox();
            this.CbxSearchBy = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvClients)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MtxBankAccount);
            this.groupBox1.Controls.Add(this.TbxEmail);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.TbxCreditLimit);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.BtnClearClientInfo);
            this.groupBox1.Controls.Add(this.BtnAddClient);
            this.groupBox1.Controls.Add(this.MtxFaxNumber);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.MtxPostalCode);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TbxAddress);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.MtxPhoneNumber);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TbxClientName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TbxClientId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(25, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(794, 223);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Client Information";
            // 
            // MtxBankAccount
            // 
            this.MtxBankAccount.Location = new System.Drawing.Point(596, 32);
            this.MtxBankAccount.Mask = "00000 000 0000000";
            this.MtxBankAccount.Name = "MtxBankAccount";
            this.MtxBankAccount.Size = new System.Drawing.Size(146, 25);
            this.MtxBankAccount.TabIndex = 2;
            // 
            // TbxEmail
            // 
            this.TbxEmail.Location = new System.Drawing.Point(596, 77);
            this.TbxEmail.Name = "TbxEmail";
            this.TbxEmail.Size = new System.Drawing.Size(146, 25);
            this.TbxEmail.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(546, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "Email";
            // 
            // TbxCreditLimit
            // 
            this.TbxCreditLimit.Location = new System.Drawing.Point(94, 165);
            this.TbxCreditLimit.Name = "TbxCreditLimit";
            this.TbxCreditLimit.Size = new System.Drawing.Size(139, 25);
            this.TbxCreditLimit.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Credit Limit";
            // 
            // BtnClearClientInfo
            // 
            this.BtnClearClientInfo.BackColor = System.Drawing.Color.Coral;
            this.BtnClearClientInfo.Location = new System.Drawing.Point(667, 174);
            this.BtnClearClientInfo.Name = "BtnClearClientInfo";
            this.BtnClearClientInfo.Size = new System.Drawing.Size(75, 30);
            this.BtnClearClientInfo.TabIndex = 10;
            this.BtnClearClientInfo.Text = "Clear";
            this.BtnClearClientInfo.UseVisualStyleBackColor = false;
            this.BtnClearClientInfo.Click += new System.EventHandler(this.BtnClearClientInfo_Click);
            // 
            // BtnAddClient
            // 
            this.BtnAddClient.BackColor = System.Drawing.Color.Aquamarine;
            this.BtnAddClient.Location = new System.Drawing.Point(566, 174);
            this.BtnAddClient.Name = "BtnAddClient";
            this.BtnAddClient.Size = new System.Drawing.Size(75, 30);
            this.BtnAddClient.TabIndex = 9;
            this.BtnAddClient.Text = "Add";
            this.BtnAddClient.UseVisualStyleBackColor = false;
            this.BtnAddClient.Click += new System.EventHandler(this.BtnAddClient_Click);
            // 
            // MtxFaxNumber
            // 
            this.MtxFaxNumber.Location = new System.Drawing.Point(348, 77);
            this.MtxFaxNumber.Mask = "000-000-0000";
            this.MtxFaxNumber.Name = "MtxFaxNumber";
            this.MtxFaxNumber.Size = new System.Drawing.Size(131, 25);
            this.MtxFaxNumber.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(261, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Fax Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(503, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Bank Account";
            // 
            // MtxPostalCode
            // 
            this.MtxPostalCode.Location = new System.Drawing.Point(609, 124);
            this.MtxPostalCode.Mask = "A0A 0A0";
            this.MtxPostalCode.Name = "MtxPostalCode";
            this.MtxPostalCode.Size = new System.Drawing.Size(107, 25);
            this.MtxPostalCode.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(523, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Postal Code";
            // 
            // TbxAddress
            // 
            this.TbxAddress.Location = new System.Drawing.Point(76, 123);
            this.TbxAddress.Name = "TbxAddress";
            this.TbxAddress.Size = new System.Drawing.Size(403, 25);
            this.TbxAddress.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Address";
            // 
            // MtxPhoneNumber
            // 
            this.MtxPhoneNumber.Location = new System.Drawing.Point(119, 77);
            this.MtxPhoneNumber.Mask = "000-000-0000";
            this.MtxPhoneNumber.Name = "MtxPhoneNumber";
            this.MtxPhoneNumber.Size = new System.Drawing.Size(111, 25);
            this.MtxPhoneNumber.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Phone Number";
            // 
            // TbxClientName
            // 
            this.TbxClientName.Location = new System.Drawing.Point(340, 32);
            this.TbxClientName.Name = "TbxClientName";
            this.TbxClientName.Size = new System.Drawing.Size(139, 25);
            this.TbxClientName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Client Name";
            // 
            // TbxClientId
            // 
            this.TbxClientId.Location = new System.Drawing.Point(76, 32);
            this.TbxClientId.Name = "TbxClientId";
            this.TbxClientId.Size = new System.Drawing.Size(155, 25);
            this.TbxClientId.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Client ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DgvClients);
            this.groupBox2.Controls.Add(this.BtnSearchClient);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.TbxSearchBy);
            this.groupBox2.Controls.Add(this.CbxSearchBy);
            this.groupBox2.Location = new System.Drawing.Point(25, 261);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(794, 302);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Client List";
            // 
            // DgvClients
            // 
            this.DgvClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvClients.Location = new System.Drawing.Point(0, 70);
            this.DgvClients.Name = "DgvClients";
            this.DgvClients.RowTemplate.Height = 25;
            this.DgvClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvClients.Size = new System.Drawing.Size(797, 234);
            this.DgvClients.TabIndex = 13;
            this.DgvClients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvItem_DoubleClick);
            // 
            // BtnSearchClient
            // 
            this.BtnSearchClient.BackColor = System.Drawing.Color.LightGreen;
            this.BtnSearchClient.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSearchClient.Location = new System.Drawing.Point(658, 25);
            this.BtnSearchClient.Name = "BtnSearchClient";
            this.BtnSearchClient.Size = new System.Drawing.Size(75, 31);
            this.BtnSearchClient.TabIndex = 13;
            this.BtnSearchClient.Text = "Search";
            this.BtnSearchClient.UseVisualStyleBackColor = false;
            this.BtnSearchClient.Click += new System.EventHandler(this.BtnSearchClient_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Search by";
            // 
            // TbxSearchBy
            // 
            this.TbxSearchBy.Location = new System.Drawing.Point(239, 30);
            this.TbxSearchBy.Name = "TbxSearchBy";
            this.TbxSearchBy.Size = new System.Drawing.Size(377, 23);
            this.TbxSearchBy.TabIndex = 12;
            // 
            // CbxSearchBy
            // 
            this.CbxSearchBy.FormattingEnabled = true;
            this.CbxSearchBy.ItemHeight = 15;
            this.CbxSearchBy.Items.AddRange(new object[] {
            "ID",
            "Client name",
            "Phone number",
            "Fax number"});
            this.CbxSearchBy.Location = new System.Drawing.Point(90, 30);
            this.CbxSearchBy.Name = "CbxSearchBy";
            this.CbxSearchBy.Size = new System.Drawing.Size(127, 23);
            this.CbxSearchBy.TabIndex = 10;
            this.CbxSearchBy.Text = "ID";
            // 
            // FrmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 583);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmClient";
            this.Text = "Client Management";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvClients)).EndInit();
            this.ResumeLayout(false);

        }

        //private void AdjustColumnOrder()
        //{
        //    DgvClients.Columns["ClientId"].DisplayIndex = 0;
        //    DgvClients.Columns["ClientName"].DisplayIndex = 1;
        //    DgvClients.Columns["PhoneNumber"].DisplayIndex = 2;
        //    DgvClients.Columns["FaxNumber"].DisplayIndex = 3;
        //    DgvClients.Columns["Email"].DisplayIndex = 4;
        //    DgvClients.Columns["Address"].DisplayIndex = 5;
        //    DgvClients.Columns["PostalCode"].DisplayIndex = 6;
        //    DgvClients.Columns["BankAccount"].DisplayIndex = 7;
        //    DgvClients.Columns["CreditLimit"].DisplayIndex = 8;
        //}
        #endregion

        private GroupBox groupBox1;
        private TextBox TbxClientId;
        private Label label1;
        private GroupBox groupBox2;
        private Label label3;
        private TextBox TbxClientName;
        private Label label2;
        private MaskedTextBox MtxPhoneNumber;
        private MaskedTextBox MtxPostalCode;
        private Label label5;
        private TextBox TbxAddress;
        private Label label4;
        private Label label6;
        private MaskedTextBox MtxFaxNumber;
        private Label label7;
        private Button BtnClearClientInfo;
        private Button BtnAddClient;
        private DataGridView DgvClients;
        private Button BtnSearchClient;
        private Label label8;
        private TextBox TbxSearchBy;
        private ComboBox CbxSearchBy;
        private TextBox TbxCreditLimit;
        private Label label9;
        private TextBox TbxEmail;
        private Label label10;
        private MaskedTextBox MtxBankAccount;
    }
}