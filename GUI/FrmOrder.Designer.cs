namespace BookBiz_Management_System.GUI
{
    partial class FrmOrder
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
            this.BtnDeleteOrderItem = new System.Windows.Forms.Button();
            this.DgvBookItems = new System.Windows.Forms.DataGridView();
            this.NudQuantity = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnAddItems = new System.Windows.Forms.Button();
            this.TbxBookTitle = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnAddOrder = new System.Windows.Forms.Button();
            this.TbxEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TbxFaxNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TbxPhoneNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TbxBankAccount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CbxOrderMethod = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MtxOrderNumber = new System.Windows.Forms.MaskedTextBox();
            this.TbxClientName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.DgvOrderList = new System.Windows.Forms.DataGridView();
            this.BtnSearchOrder = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.TbxSearchBy = new System.Windows.Forms.TextBox();
            this.CbxSearchBy = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBookItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudQuantity)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrderList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnDeleteOrderItem);
            this.groupBox1.Controls.Add(this.DgvBookItems);
            this.groupBox1.Controls.Add(this.NudQuantity);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.BtnAddItems);
            this.groupBox1.Controls.Add(this.TbxBookTitle);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.BtnClear);
            this.groupBox1.Controls.Add(this.BtnAddOrder);
            this.groupBox1.Controls.Add(this.TbxEmail);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TbxFaxNumber);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TbxPhoneNumber);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TbxBankAccount);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.CbxOrderMethod);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.MtxOrderNumber);
            this.groupBox1.Controls.Add(this.TbxClientName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(824, 442);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Information";
            // 
            // BtnDeleteOrderItem
            // 
            this.BtnDeleteOrderItem.BackColor = System.Drawing.Color.Tomato;
            this.BtnDeleteOrderItem.Location = new System.Drawing.Point(622, 125);
            this.BtnDeleteOrderItem.Name = "BtnDeleteOrderItem";
            this.BtnDeleteOrderItem.Size = new System.Drawing.Size(75, 23);
            this.BtnDeleteOrderItem.TabIndex = 21;
            this.BtnDeleteOrderItem.Text = "Delete";
            this.BtnDeleteOrderItem.UseVisualStyleBackColor = false;
            this.BtnDeleteOrderItem.Click += new System.EventHandler(this.BtnDeleteOrderItem_Click);
            // 
            // DgvBookItems
            // 
            this.DgvBookItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvBookItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvBookItems.Location = new System.Drawing.Point(0, 168);
            this.DgvBookItems.Name = "DgvBookItems";
            this.DgvBookItems.RowTemplate.Height = 25;
            this.DgvBookItems.Size = new System.Drawing.Size(824, 215);
            this.DgvBookItems.TabIndex = 20;
            // 
            // NudQuantity
            // 
            this.NudQuantity.Location = new System.Drawing.Point(402, 126);
            this.NudQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudQuantity.Name = "NudQuantity";
            this.NudQuantity.Size = new System.Drawing.Size(71, 23);
            this.NudQuantity.TabIndex = 19;
            this.NudQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(343, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 15);
            this.label10.TabIndex = 18;
            this.label10.Text = "Quantity";
            // 
            // BtnAddItems
            // 
            this.BtnAddItems.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnAddItems.Location = new System.Drawing.Point(516, 126);
            this.BtnAddItems.Name = "BtnAddItems";
            this.BtnAddItems.Size = new System.Drawing.Size(88, 23);
            this.BtnAddItems.TabIndex = 8;
            this.BtnAddItems.Text = "Add Items";
            this.BtnAddItems.UseVisualStyleBackColor = false;
            this.BtnAddItems.Click += new System.EventHandler(this.BtnAddItems_Click);
            // 
            // TbxBookTitle
            // 
            this.TbxBookTitle.Location = new System.Drawing.Point(91, 126);
            this.TbxBookTitle.Name = "TbxBookTitle";
            this.TbxBookTitle.Size = new System.Drawing.Size(221, 23);
            this.TbxBookTitle.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "Book TItle";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.Color.Coral;
            this.BtnClear.Location = new System.Drawing.Point(653, 399);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(75, 23);
            this.BtnClear.TabIndex = 10;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnAddOrder
            // 
            this.BtnAddOrder.BackColor = System.Drawing.Color.Aquamarine;
            this.BtnAddOrder.Location = new System.Drawing.Point(541, 399);
            this.BtnAddOrder.Name = "BtnAddOrder";
            this.BtnAddOrder.Size = new System.Drawing.Size(88, 23);
            this.BtnAddOrder.TabIndex = 9;
            this.BtnAddOrder.Text = "Add Order";
            this.BtnAddOrder.UseVisualStyleBackColor = false;
            this.BtnAddOrder.Click += new System.EventHandler(this.BtnAddOrder_Click);
            // 
            // TbxEmail
            // 
            this.TbxEmail.Location = new System.Drawing.Point(688, 72);
            this.TbxEmail.Name = "TbxEmail";
            this.TbxEmail.Size = new System.Drawing.Size(117, 23);
            this.TbxEmail.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(643, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Email";
            // 
            // TbxFaxNumber
            // 
            this.TbxFaxNumber.Location = new System.Drawing.Point(501, 72);
            this.TbxFaxNumber.Name = "TbxFaxNumber";
            this.TbxFaxNumber.Size = new System.Drawing.Size(121, 23);
            this.TbxFaxNumber.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(420, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Fax Number";
            // 
            // TbxPhoneNumber
            // 
            this.TbxPhoneNumber.Location = new System.Drawing.Point(315, 72);
            this.TbxPhoneNumber.Name = "TbxPhoneNumber";
            this.TbxPhoneNumber.Size = new System.Drawing.Size(88, 23);
            this.TbxPhoneNumber.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(224, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Phone Number";
            // 
            // TbxBankAccount
            // 
            this.TbxBankAccount.Location = new System.Drawing.Point(101, 72);
            this.TbxBankAccount.Name = "TbxBankAccount";
            this.TbxBankAccount.Size = new System.Drawing.Size(108, 23);
            this.TbxBankAccount.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Bank Account";
            // 
            // CbxOrderMethod
            // 
            this.CbxOrderMethod.FormattingEnabled = true;
            this.CbxOrderMethod.Items.AddRange(new object[] {
            "By Phone",
            "By Fax",
            "By Email"});
            this.CbxOrderMethod.Location = new System.Drawing.Point(610, 28);
            this.CbxOrderMethod.Name = "CbxOrderMethod";
            this.CbxOrderMethod.Size = new System.Drawing.Size(121, 23);
            this.CbxOrderMethod.TabIndex = 2;
            this.CbxOrderMethod.Text = "By Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(522, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Order method";
            // 
            // MtxOrderNumber
            // 
            this.MtxOrderNumber.Location = new System.Drawing.Point(78, 27);
            this.MtxOrderNumber.Mask = "PO00000";
            this.MtxOrderNumber.Name = "MtxOrderNumber";
            this.MtxOrderNumber.Size = new System.Drawing.Size(100, 23);
            this.MtxOrderNumber.TabIndex = 0;
            // 
            // TbxClientName
            // 
            this.TbxClientName.Location = new System.Drawing.Point(302, 27);
            this.TbxClientName.Name = "TbxClientName";
            this.TbxClientName.Size = new System.Drawing.Size(154, 23);
            this.TbxClientName.TabIndex = 1;
            this.TbxClientName.Leave += new System.EventHandler(this.TbxClientName_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Client Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order No.";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnUpdate);
            this.groupBox2.Controls.Add(this.BtnDelete);
            this.groupBox2.Controls.Add(this.DgvOrderList);
            this.groupBox2.Controls.Add(this.BtnSearchOrder);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.TbxSearchBy);
            this.groupBox2.Controls.Add(this.CbxSearchBy);
            this.groupBox2.Location = new System.Drawing.Point(9, 456);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(824, 305);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Order List";
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.PeachPuff;
            this.BtnUpdate.Location = new System.Drawing.Point(569, 21);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(75, 31);
            this.BtnUpdate.TabIndex = 23;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.Tomato;
            this.BtnDelete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnDelete.Location = new System.Drawing.Point(672, 21);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 31);
            this.BtnDelete.TabIndex = 24;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // DgvOrderList
            // 
            this.DgvOrderList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvOrderList.Location = new System.Drawing.Point(0, 66);
            this.DgvOrderList.Name = "DgvOrderList";
            this.DgvOrderList.RowTemplate.Height = 25;
            this.DgvOrderList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvOrderList.Size = new System.Drawing.Size(818, 241);
            this.DgvOrderList.TabIndex = 22;
            this.DgvOrderList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvOrderList_CellDoubleClick);
            // 
            // BtnSearchOrder
            // 
            this.BtnSearchOrder.BackColor = System.Drawing.Color.LightGreen;
            this.BtnSearchOrder.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSearchOrder.Location = new System.Drawing.Point(466, 21);
            this.BtnSearchOrder.Name = "BtnSearchOrder";
            this.BtnSearchOrder.Size = new System.Drawing.Size(75, 31);
            this.BtnSearchOrder.TabIndex = 13;
            this.BtnSearchOrder.Text = "Search";
            this.BtnSearchOrder.UseVisualStyleBackColor = false;
            this.BtnSearchOrder.Click += new System.EventHandler(this.BtnSearchOrder_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "Search by";
            // 
            // TbxSearchBy
            // 
            this.TbxSearchBy.Location = new System.Drawing.Point(231, 26);
            this.TbxSearchBy.Name = "TbxSearchBy";
            this.TbxSearchBy.Size = new System.Drawing.Size(208, 23);
            this.TbxSearchBy.TabIndex = 12;
            // 
            // CbxSearchBy
            // 
            this.CbxSearchBy.FormattingEnabled = true;
            this.CbxSearchBy.ItemHeight = 15;
            this.CbxSearchBy.Items.AddRange(new object[] {
            "Order Number",
            "Client Name",
            "Order Method"});
            this.CbxSearchBy.Location = new System.Drawing.Point(82, 26);
            this.CbxSearchBy.Name = "CbxSearchBy";
            this.CbxSearchBy.Size = new System.Drawing.Size(127, 23);
            this.CbxSearchBy.TabIndex = 11;
            this.CbxSearchBy.Text = "Order Number";
            // 
            // FrmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 773);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmOrder";
            this.Text = "Order management";
            this.Load += new System.EventHandler(this.FrmOrder_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBookItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudQuantity)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrderList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox TbxClientName;
        private Label label2;
        private Button BtnClear;
        private Button BtnAddOrder;
        private TextBox TbxEmail;
        private Label label7;
        private TextBox TbxFaxNumber;
        private Label label6;
        private TextBox TbxPhoneNumber;
        private Label label5;
        private TextBox TbxBankAccount;
        private Label label4;
        private ComboBox CbxOrderMethod;
        private Label label3;
        private MaskedTextBox MtxOrderNumber;
        private Button BtnAddItems;
        private TextBox TbxBookTitle;
        private Label label8;
        private GroupBox groupBox2;
        private DataGridView DgvOrderList;
        private Button BtnSearchOrder;
        private Label label9;
        private TextBox TbxSearchBy;
        private ComboBox CbxSearchBy;
        private Button BtnDelete;
        private Label label10;
        private DataGridView DgvBookItems;
        private NumericUpDown NudQuantity;
        private Button BtnDeleteOrderItem;
        private Button BtnUpdate;
    }
}