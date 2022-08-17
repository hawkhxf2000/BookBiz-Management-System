namespace BookBiz_Management_System.GUI
{
    partial class FrmOrderItem
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnSearchBook = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.TbxSearchBy = new System.Windows.Forms.TextBox();
            this.CbxSearchBy = new System.Windows.Forms.ComboBox();
            this.DgvBookList = new System.Windows.Forms.DataGridView();
            this.BtnAddItem = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBookList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnAddItem);
            this.groupBox2.Controls.Add(this.BtnSearchBook);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.TbxSearchBy);
            this.groupBox2.Controls.Add(this.CbxSearchBy);
            this.groupBox2.Controls.Add(this.DgvBookList);
            this.groupBox2.Location = new System.Drawing.Point(11, 9);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(740, 292);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Book List";
            // 
            // BtnSearchBook
            // 
            this.BtnSearchBook.BackColor = System.Drawing.Color.LightGreen;
            this.BtnSearchBook.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSearchBook.Location = new System.Drawing.Point(464, 24);
            this.BtnSearchBook.Name = "BtnSearchBook";
            this.BtnSearchBook.Size = new System.Drawing.Size(75, 31);
            this.BtnSearchBook.TabIndex = 2;
            this.BtnSearchBook.Text = "Search";
            this.BtnSearchBook.UseVisualStyleBackColor = false;
            this.BtnSearchBook.Click += new System.EventHandler(this.BtnSearchBook_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Search by";
            // 
            // TbxSearchBy
            // 
            this.TbxSearchBy.Location = new System.Drawing.Point(229, 29);
            this.TbxSearchBy.Name = "TbxSearchBy";
            this.TbxSearchBy.Size = new System.Drawing.Size(208, 23);
            this.TbxSearchBy.TabIndex = 1;
            // 
            // CbxSearchBy
            // 
            this.CbxSearchBy.FormattingEnabled = true;
            this.CbxSearchBy.ItemHeight = 15;
            this.CbxSearchBy.Items.AddRange(new object[] {
            "ISBN",
            "Title",
            "Author"});
            this.CbxSearchBy.Location = new System.Drawing.Point(80, 29);
            this.CbxSearchBy.Name = "CbxSearchBy";
            this.CbxSearchBy.Size = new System.Drawing.Size(127, 23);
            this.CbxSearchBy.TabIndex = 0;
            this.CbxSearchBy.Text = "ISBN";
            // 
            // DgvBookList
            // 
            this.DgvBookList.AllowUserToAddRows = false;
            this.DgvBookList.AllowUserToDeleteRows = false;
            this.DgvBookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvBookList.Location = new System.Drawing.Point(0, 61);
            this.DgvBookList.Name = "DgvBookList";
            this.DgvBookList.RowTemplate.Height = 25;
            this.DgvBookList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvBookList.Size = new System.Drawing.Size(740, 226);
            this.DgvBookList.TabIndex = 0;
            // 
            // BtnAddItem
            // 
            this.BtnAddItem.BackColor = System.Drawing.Color.Coral;
            this.BtnAddItem.Location = new System.Drawing.Point(555, 24);
            this.BtnAddItem.Name = "BtnAddItem";
            this.BtnAddItem.Size = new System.Drawing.Size(82, 31);
            this.BtnAddItem.TabIndex = 3;
            this.BtnAddItem.Text = "Add Item";
            this.BtnAddItem.UseVisualStyleBackColor = false;
            this.BtnAddItem.Click += new System.EventHandler(this.BtnAddItem_Click);
            // 
            // FrmOrderItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 314);
            this.Controls.Add(this.groupBox2);
            this.Name = "FrmOrderItem";
            this.Text = "FrmOrderItem";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBookList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox2;
        private Button BtnSearchBook;
        private Label label8;
        private TextBox TbxSearchBy;
        private ComboBox CbxSearchBy;
        private DataGridView DgvBookList;
        private Button BtnAddItem;
    }
}