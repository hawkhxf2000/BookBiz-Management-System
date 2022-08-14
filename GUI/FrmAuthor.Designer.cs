namespace BookBiz_Management_System.GUI
{
    partial class FrmAuthor
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
            this.label1 = new System.Windows.Forms.Label();
            this.TbxAuthorId = new System.Windows.Forms.TextBox();
            this.TbxFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TbxLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TbxEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnAddAuthor = new System.Windows.Forms.Button();
            this.GbxAuthorInfo = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnAddToBook = new System.Windows.Forms.Button();
            this.DgvAuthorList = new System.Windows.Forms.DataGridView();
            this.BtnSearchAuthor = new System.Windows.Forms.Button();
            this.CbxSearchBy = new System.Windows.Forms.ComboBox();
            this.TbxSearchBy = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.GbxAuthorInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAuthorList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Author ID";
            // 
            // TbxAuthorId
            // 
            this.TbxAuthorId.Location = new System.Drawing.Point(77, 30);
            this.TbxAuthorId.Name = "TbxAuthorId";
            this.TbxAuthorId.Size = new System.Drawing.Size(100, 23);
            this.TbxAuthorId.TabIndex = 1;
            // 
            // TbxFirstName
            // 
            this.TbxFirstName.Location = new System.Drawing.Point(286, 26);
            this.TbxFirstName.Name = "TbxFirstName";
            this.TbxFirstName.Size = new System.Drawing.Size(100, 23);
            this.TbxFirstName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name";
            // 
            // TbxLastName
            // 
            this.TbxLastName.Location = new System.Drawing.Point(77, 81);
            this.TbxLastName.Name = "TbxLastName";
            this.TbxLastName.Size = new System.Drawing.Size(100, 23);
            this.TbxLastName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last Name";
            // 
            // TbxEmail
            // 
            this.TbxEmail.Location = new System.Drawing.Point(287, 81);
            this.TbxEmail.Name = "TbxEmail";
            this.TbxEmail.Size = new System.Drawing.Size(100, 23);
            this.TbxEmail.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email";
            // 
            // BtnAddAuthor
            // 
            this.BtnAddAuthor.BackColor = System.Drawing.Color.Aquamarine;
            this.BtnAddAuthor.Location = new System.Drawing.Point(26, 124);
            this.BtnAddAuthor.Name = "BtnAddAuthor";
            this.BtnAddAuthor.Size = new System.Drawing.Size(75, 30);
            this.BtnAddAuthor.TabIndex = 10;
            this.BtnAddAuthor.Text = "Add";
            this.BtnAddAuthor.UseVisualStyleBackColor = false;
            this.BtnAddAuthor.Click += new System.EventHandler(this.BtnAddAuthor_Click);
            // 
            // GbxAuthorInfo
            // 
            this.GbxAuthorInfo.Controls.Add(this.label3);
            this.GbxAuthorInfo.Controls.Add(this.label1);
            this.GbxAuthorInfo.Controls.Add(this.BtnAddAuthor);
            this.GbxAuthorInfo.Controls.Add(this.TbxAuthorId);
            this.GbxAuthorInfo.Controls.Add(this.TbxEmail);
            this.GbxAuthorInfo.Controls.Add(this.label2);
            this.GbxAuthorInfo.Controls.Add(this.label4);
            this.GbxAuthorInfo.Controls.Add(this.TbxFirstName);
            this.GbxAuthorInfo.Controls.Add(this.TbxLastName);
            this.GbxAuthorInfo.Location = new System.Drawing.Point(17, 4);
            this.GbxAuthorInfo.Name = "GbxAuthorInfo";
            this.GbxAuthorInfo.Size = new System.Drawing.Size(404, 177);
            this.GbxAuthorInfo.TabIndex = 12;
            this.GbxAuthorInfo.TabStop = false;
            this.GbxAuthorInfo.Text = "Author Information";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnAddToBook);
            this.groupBox1.Controls.Add(this.DgvAuthorList);
            this.groupBox1.Controls.Add(this.BtnSearchAuthor);
            this.groupBox1.Controls.Add(this.CbxSearchBy);
            this.groupBox1.Controls.Add(this.TbxSearchBy);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(17, 201);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 235);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Author List";
            // 
            // BtnAddToBook
            // 
            this.BtnAddToBook.BackColor = System.Drawing.Color.Aquamarine;
            this.BtnAddToBook.Location = new System.Drawing.Point(16, 199);
            this.BtnAddToBook.Name = "BtnAddToBook";
            this.BtnAddToBook.Size = new System.Drawing.Size(98, 23);
            this.BtnAddToBook.TabIndex = 5;
            this.BtnAddToBook.Text = "Add To Book";
            this.BtnAddToBook.UseVisualStyleBackColor = false;
            this.BtnAddToBook.Click += new System.EventHandler(this.BtnAddToBook_Click);
            // 
            // DgvAuthorList
            // 
            this.DgvAuthorList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAuthorList.Location = new System.Drawing.Point(0, 68);
            this.DgvAuthorList.Name = "DgvAuthorList";
            this.DgvAuthorList.RowTemplate.Height = 25;
            this.DgvAuthorList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvAuthorList.Size = new System.Drawing.Size(404, 125);
            this.DgvAuthorList.TabIndex = 4;
            // 
            // BtnSearchAuthor
            // 
            this.BtnSearchAuthor.BackColor = System.Drawing.Color.LightGreen;
            this.BtnSearchAuthor.Location = new System.Drawing.Point(312, 32);
            this.BtnSearchAuthor.Name = "BtnSearchAuthor";
            this.BtnSearchAuthor.Size = new System.Drawing.Size(75, 23);
            this.BtnSearchAuthor.TabIndex = 3;
            this.BtnSearchAuthor.Text = "Search";
            this.BtnSearchAuthor.UseVisualStyleBackColor = false;
            this.BtnSearchAuthor.Click += new System.EventHandler(this.BtnSearchAuthor_Click);
            // 
            // CbxSearchBy
            // 
            this.CbxSearchBy.FormattingEnabled = true;
            this.CbxSearchBy.Items.AddRange(new object[] {
            "First Name",
            "Last Name"});
            this.CbxSearchBy.Location = new System.Drawing.Point(77, 32);
            this.CbxSearchBy.Name = "CbxSearchBy";
            this.CbxSearchBy.Size = new System.Drawing.Size(79, 23);
            this.CbxSearchBy.TabIndex = 2;
            this.CbxSearchBy.Text = "First Name";
            // 
            // TbxSearchBy
            // 
            this.TbxSearchBy.Location = new System.Drawing.Point(172, 32);
            this.TbxSearchBy.Name = "TbxSearchBy";
            this.TbxSearchBy.Size = new System.Drawing.Size(124, 23);
            this.TbxSearchBy.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Search By";
            // 
            // FrmAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 448);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GbxAuthorInfo);
            this.Name = "FrmAuthor";
            this.Text = "Add New Author";
            this.GbxAuthorInfo.ResumeLayout(false);
            this.GbxAuthorInfo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAuthorList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private TextBox TbxAuthorId;
        private TextBox TbxFirstName;
        private Label label2;
        private TextBox TbxLastName;
        private Label label3;
        private TextBox TbxEmail;
        private Label label4;
        private Button BtnAddAuthor;
        private GroupBox GbxAuthorInfo;
        private GroupBox groupBox1;
        private Button BtnSearchAuthor;
        private ComboBox CbxSearchBy;
        private TextBox TbxSearchBy;
        private Label label5;
        private DataGridView DgvAuthorList;
        private Button BtnAddToBook;
    }
}