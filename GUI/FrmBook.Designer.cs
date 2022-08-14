namespace BookBiz_Management_System
{
    partial class FrmBook
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
            this.lbl_ISBN = new System.Windows.Forms.Label();
            this.TbxISBN = new System.Windows.Forms.TextBox();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.TbxTitle = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnAddPublisher = new System.Windows.Forms.Button();
            this.NudQOH = new System.Windows.Forms.NumericUpDown();
            this.CbxCategory = new System.Windows.Forms.ComboBox();
            this.BtnSearchAuthor = new System.Windows.Forms.Button();
            this.BtnClearClientInfo = new System.Windows.Forms.Button();
            this.TbxAuthor = new System.Windows.Forms.TextBox();
            this.BtnAddClient = new System.Windows.Forms.Button();
            this.lbl_authors = new System.Windows.Forms.Label();
            this.lbl_publisher = new System.Windows.Forms.Label();
            this.CbxPublisher = new System.Windows.Forms.ComboBox();
            this.lbl_QOH = new System.Windows.Forms.Label();
            this.TbxUnitPrice = new System.Windows.Forms.TextBox();
            this.lbl_uPrice = new System.Windows.Forms.Label();
            this.lbl_category = new System.Windows.Forms.Label();
            this.TbxPublishYear = new System.Windows.Forms.TextBox();
            this.lbl_PubYear = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnSearchClient = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.TbxSearchBy = new System.Windows.Forms.TextBox();
            this.CbxSearchBy = new System.Windows.Forms.ComboBox();
            this.DgvBookList = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudQOH)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBookList)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ISBN
            // 
            this.lbl_ISBN.AutoSize = true;
            this.lbl_ISBN.Location = new System.Drawing.Point(8, 29);
            this.lbl_ISBN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ISBN.Name = "lbl_ISBN";
            this.lbl_ISBN.Size = new System.Drawing.Size(32, 15);
            this.lbl_ISBN.TabIndex = 1;
            this.lbl_ISBN.Text = "ISBN";
            this.lbl_ISBN.Click += new System.EventHandler(this.label2_Click);
            // 
            // TbxISBN
            // 
            this.TbxISBN.Location = new System.Drawing.Point(87, 25);
            this.TbxISBN.Margin = new System.Windows.Forms.Padding(2);
            this.TbxISBN.Name = "TbxISBN";
            this.TbxISBN.Size = new System.Drawing.Size(97, 23);
            this.TbxISBN.TabIndex = 0;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Location = new System.Drawing.Point(233, 28);
            this.lbl_Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(29, 15);
            this.lbl_Title.TabIndex = 3;
            this.lbl_Title.Text = "Title";
            // 
            // TbxTitle
            // 
            this.TbxTitle.Location = new System.Drawing.Point(285, 25);
            this.TbxTitle.Margin = new System.Windows.Forms.Padding(2);
            this.TbxTitle.Name = "TbxTitle";
            this.TbxTitle.Size = new System.Drawing.Size(152, 23);
            this.TbxTitle.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnAddPublisher);
            this.groupBox1.Controls.Add(this.NudQOH);
            this.groupBox1.Controls.Add(this.CbxCategory);
            this.groupBox1.Controls.Add(this.BtnSearchAuthor);
            this.groupBox1.Controls.Add(this.BtnClearClientInfo);
            this.groupBox1.Controls.Add(this.TbxAuthor);
            this.groupBox1.Controls.Add(this.BtnAddClient);
            this.groupBox1.Controls.Add(this.lbl_authors);
            this.groupBox1.Controls.Add(this.lbl_publisher);
            this.groupBox1.Controls.Add(this.CbxPublisher);
            this.groupBox1.Controls.Add(this.lbl_QOH);
            this.groupBox1.Controls.Add(this.TbxUnitPrice);
            this.groupBox1.Controls.Add(this.lbl_uPrice);
            this.groupBox1.Controls.Add(this.lbl_category);
            this.groupBox1.Controls.Add(this.TbxPublishYear);
            this.groupBox1.Controls.Add(this.lbl_PubYear);
            this.groupBox1.Controls.Add(this.TbxTitle);
            this.groupBox1.Controls.Add(this.lbl_Title);
            this.groupBox1.Controls.Add(this.TbxISBN);
            this.groupBox1.Controls.Add(this.lbl_ISBN);
            this.groupBox1.Location = new System.Drawing.Point(9, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(740, 184);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Book Information";
            // 
            // BtnAddPublisher
            // 
            this.BtnAddPublisher.BackColor = System.Drawing.Color.Aquamarine;
            this.BtnAddPublisher.Location = new System.Drawing.Point(285, 125);
            this.BtnAddPublisher.Name = "BtnAddPublisher";
            this.BtnAddPublisher.Size = new System.Drawing.Size(108, 23);
            this.BtnAddPublisher.TabIndex = 19;
            this.BtnAddPublisher.Text = "Add Publisher";
            this.BtnAddPublisher.UseVisualStyleBackColor = false;
            this.BtnAddPublisher.Click += new System.EventHandler(this.BtnAddPublisher_Click);
            // 
            // NudQOH
            // 
            this.NudQOH.Location = new System.Drawing.Point(541, 56);
            this.NudQOH.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudQOH.Name = "NudQOH";
            this.NudQOH.Size = new System.Drawing.Size(55, 23);
            this.NudQOH.TabIndex = 5;
            this.NudQOH.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CbxCategory
            // 
            this.CbxCategory.FormattingEnabled = true;
            this.CbxCategory.Items.AddRange(new object[] {
            "Programming",
            "CyberSecurity",
            "E-business",
            "Web technology"});
            this.CbxCategory.Location = new System.Drawing.Point(541, 24);
            this.CbxCategory.Name = "CbxCategory";
            this.CbxCategory.Size = new System.Drawing.Size(147, 23);
            this.CbxCategory.TabIndex = 2;
            // 
            // BtnSearchAuthor
            // 
            this.BtnSearchAuthor.BackColor = System.Drawing.Color.PeachPuff;
            this.BtnSearchAuthor.Location = new System.Drawing.Point(593, 92);
            this.BtnSearchAuthor.Name = "BtnSearchAuthor";
            this.BtnSearchAuthor.Size = new System.Drawing.Size(100, 23);
            this.BtnSearchAuthor.TabIndex = 7;
            this.BtnSearchAuthor.Text = "Search Author";
            this.BtnSearchAuthor.UseVisualStyleBackColor = false;
            this.BtnSearchAuthor.Click += new System.EventHandler(this.BtnSearchAuthor_Click);
            // 
            // BtnClearClientInfo
            // 
            this.BtnClearClientInfo.BackColor = System.Drawing.Color.Coral;
            this.BtnClearClientInfo.Location = new System.Drawing.Point(613, 140);
            this.BtnClearClientInfo.Name = "BtnClearClientInfo";
            this.BtnClearClientInfo.Size = new System.Drawing.Size(75, 30);
            this.BtnClearClientInfo.TabIndex = 10;
            this.BtnClearClientInfo.Text = "Clear";
            this.BtnClearClientInfo.UseVisualStyleBackColor = false;
            this.BtnClearClientInfo.Click += new System.EventHandler(this.BtnClearClientInfo_Click);
            // 
            // TbxAuthor
            // 
            this.TbxAuthor.AutoCompleteCustomSource.AddRange(new string[] {
            "Shelly Moore",
            "Jody Houser"});
            this.TbxAuthor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TbxAuthor.Location = new System.Drawing.Point(88, 93);
            this.TbxAuthor.Margin = new System.Windows.Forms.Padding(2);
            this.TbxAuthor.Name = "TbxAuthor";
            this.TbxAuthor.PlaceholderText = "Please search author at first ";
            this.TbxAuthor.ReadOnly = true;
            this.TbxAuthor.Size = new System.Drawing.Size(481, 23);
            this.TbxAuthor.TabIndex = 6;
            this.TbxAuthor.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // BtnAddClient
            // 
            this.BtnAddClient.BackColor = System.Drawing.Color.Aquamarine;
            this.BtnAddClient.Location = new System.Drawing.Point(512, 140);
            this.BtnAddClient.Name = "BtnAddClient";
            this.BtnAddClient.Size = new System.Drawing.Size(75, 30);
            this.BtnAddClient.TabIndex = 9;
            this.BtnAddClient.Text = "Add";
            this.BtnAddClient.UseVisualStyleBackColor = false;
            this.BtnAddClient.Click += new System.EventHandler(this.BtnAddClient_Click);
            // 
            // lbl_authors
            // 
            this.lbl_authors.AutoSize = true;
            this.lbl_authors.Location = new System.Drawing.Point(8, 97);
            this.lbl_authors.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_authors.Name = "lbl_authors";
            this.lbl_authors.Size = new System.Drawing.Size(49, 15);
            this.lbl_authors.TabIndex = 18;
            this.lbl_authors.Text = "Authors";
            this.lbl_authors.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // lbl_publisher
            // 
            this.lbl_publisher.AutoSize = true;
            this.lbl_publisher.Location = new System.Drawing.Point(8, 128);
            this.lbl_publisher.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_publisher.Name = "lbl_publisher";
            this.lbl_publisher.Size = new System.Drawing.Size(56, 15);
            this.lbl_publisher.TabIndex = 17;
            this.lbl_publisher.Text = "Publisher";
            // 
            // CbxPublisher
            // 
            this.CbxPublisher.FormattingEnabled = true;
            this.CbxPublisher.Location = new System.Drawing.Point(87, 125);
            this.CbxPublisher.Margin = new System.Windows.Forms.Padding(2);
            this.CbxPublisher.Name = "CbxPublisher";
            this.CbxPublisher.Size = new System.Drawing.Size(175, 23);
            this.CbxPublisher.TabIndex = 8;
            // 
            // lbl_QOH
            // 
            this.lbl_QOH.AutoSize = true;
            this.lbl_QOH.Location = new System.Drawing.Point(475, 61);
            this.lbl_QOH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_QOH.Name = "lbl_QOH";
            this.lbl_QOH.Size = new System.Drawing.Size(34, 15);
            this.lbl_QOH.TabIndex = 15;
            this.lbl_QOH.Text = "QOH";
            // 
            // TbxUnitPrice
            // 
            this.TbxUnitPrice.Location = new System.Drawing.Point(285, 56);
            this.TbxUnitPrice.Margin = new System.Windows.Forms.Padding(2);
            this.TbxUnitPrice.Name = "TbxUnitPrice";
            this.TbxUnitPrice.Size = new System.Drawing.Size(108, 23);
            this.TbxUnitPrice.TabIndex = 4;
            // 
            // lbl_uPrice
            // 
            this.lbl_uPrice.AutoSize = true;
            this.lbl_uPrice.Location = new System.Drawing.Point(204, 60);
            this.lbl_uPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_uPrice.Name = "lbl_uPrice";
            this.lbl_uPrice.Size = new System.Drawing.Size(58, 15);
            this.lbl_uPrice.TabIndex = 13;
            this.lbl_uPrice.Text = "Unit Price";
            // 
            // lbl_category
            // 
            this.lbl_category.AutoSize = true;
            this.lbl_category.Location = new System.Drawing.Point(475, 27);
            this.lbl_category.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(55, 15);
            this.lbl_category.TabIndex = 7;
            this.lbl_category.Text = "Category";
            // 
            // TbxPublishYear
            // 
            this.TbxPublishYear.Location = new System.Drawing.Point(88, 61);
            this.TbxPublishYear.Margin = new System.Windows.Forms.Padding(2);
            this.TbxPublishYear.Name = "TbxPublishYear";
            this.TbxPublishYear.Size = new System.Drawing.Size(97, 23);
            this.TbxPublishYear.TabIndex = 3;
            // 
            // lbl_PubYear
            // 
            this.lbl_PubYear.AutoSize = true;
            this.lbl_PubYear.Location = new System.Drawing.Point(8, 64);
            this.lbl_PubYear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_PubYear.Name = "lbl_PubYear";
            this.lbl_PubYear.Size = new System.Drawing.Size(71, 15);
            this.lbl_PubYear.TabIndex = 5;
            this.lbl_PubYear.Text = "Publish Year";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnSearchClient);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.TbxSearchBy);
            this.groupBox2.Controls.Add(this.CbxSearchBy);
            this.groupBox2.Controls.Add(this.DgvBookList);
            this.groupBox2.Location = new System.Drawing.Point(9, 216);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(740, 292);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Book List";
            // 
            // BtnSearchClient
            // 
            this.BtnSearchClient.BackColor = System.Drawing.Color.LightGreen;
            this.BtnSearchClient.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSearchClient.Location = new System.Drawing.Point(464, 24);
            this.BtnSearchClient.Name = "BtnSearchClient";
            this.BtnSearchClient.Size = new System.Drawing.Size(75, 31);
            this.BtnSearchClient.TabIndex = 17;
            this.BtnSearchClient.Text = "Search";
            this.BtnSearchClient.UseVisualStyleBackColor = false;
            this.BtnSearchClient.Click += new System.EventHandler(this.BtnSearchClient_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 33);
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
            this.TbxSearchBy.TabIndex = 16;
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
            this.CbxSearchBy.TabIndex = 15;
            this.CbxSearchBy.Text = "ISBN";
            // 
            // DgvBookList
            // 
            this.DgvBookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvBookList.Location = new System.Drawing.Point(0, 61);
            this.DgvBookList.Name = "DgvBookList";
            this.DgvBookList.RowTemplate.Height = 25;
            this.DgvBookList.Size = new System.Drawing.Size(740, 226);
            this.DgvBookList.TabIndex = 0;
            // 
            // FrmBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 530);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmBook";
            this.Text = "Book Record";
            this.Load += new System.EventHandler(this.FrmBook_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudQOH)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBookList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Label lbl_ISBN;
        private TextBox tbx_ISBN;
        private Label lbl_Title;
        private TextBox TbxTitle;
        private GroupBox groupBox1;
        private Label lbl_category;
        private TextBox TbxPublishYear;
        private Label lbl_PubYear;
        private Label lbl_publisher;
        private Label lbl_QOH;
        private TextBox TbxUnitPrice;
        private Label lbl_uPrice;
        private ComboBox CbxPublisher;
        private TextBox TbxAuthor;
        private Label lbl_authors;
        private GroupBox groupBox2;
        private Button BtnClearClientInfo;
        private Button BtnAddClient;
        private TextBox TbxISBN;
        private Button BtnSearchAuthor;
        private NumericUpDown NudQOH;
        private ComboBox CbxCategory;
        private DataGridView DgvBookList;
        private Button BtnSearchClient;
        private Label label8;
        private TextBox TbxSearchBy;
        private ComboBox CbxSearchBy;
        private Button BtnAddPublisher;
    }
}