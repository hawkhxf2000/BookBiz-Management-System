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
            this.tbx_ISBN = new System.Windows.Forms.TextBox();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.tbx_title = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbx_authors = new System.Windows.Forms.TextBox();
            this.lbl_authors = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_publisher = new System.Windows.Forms.Label();
            this.cbx_publisher = new System.Windows.Forms.ComboBox();
            this.tbx_QOH = new System.Windows.Forms.TextBox();
            this.lbl_QOH = new System.Windows.Forms.Label();
            this.tbx_uPrice = new System.Windows.Forms.TextBox();
            this.lbl_uPrice = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbl_category = new System.Windows.Forms.Label();
            this.tbx_pubYear = new System.Windows.Forms.TextBox();
            this.lbl_PubYear = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_ISBN
            // 
            this.lbl_ISBN.AutoSize = true;
            this.lbl_ISBN.Location = new System.Drawing.Point(12, 46);
            this.lbl_ISBN.Name = "lbl_ISBN";
            this.lbl_ISBN.Size = new System.Drawing.Size(51, 24);
            this.lbl_ISBN.TabIndex = 1;
            this.lbl_ISBN.Text = "ISBN";
            this.lbl_ISBN.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbx_ISBN
            // 
            this.tbx_ISBN.Location = new System.Drawing.Point(136, 40);
            this.tbx_ISBN.Name = "tbx_ISBN";
            this.tbx_ISBN.Size = new System.Drawing.Size(150, 30);
            this.tbx_ISBN.TabIndex = 2;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Location = new System.Drawing.Point(362, 46);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(47, 24);
            this.lbl_Title.TabIndex = 3;
            this.lbl_Title.Text = "Title";
            // 
            // tbx_title
            // 
            this.tbx_title.Location = new System.Drawing.Point(465, 40);
            this.tbx_title.Name = "tbx_title";
            this.tbx_title.Size = new System.Drawing.Size(237, 30);
            this.tbx_title.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbx_authors);
            this.groupBox1.Controls.Add(this.lbl_authors);
            this.groupBox1.Controls.Add(this.lbl_publisher);
            this.groupBox1.Controls.Add(this.cbx_publisher);
            this.groupBox1.Controls.Add(this.tbx_QOH);
            this.groupBox1.Controls.Add(this.lbl_QOH);
            this.groupBox1.Controls.Add(this.tbx_uPrice);
            this.groupBox1.Controls.Add(this.lbl_uPrice);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.lbl_category);
            this.groupBox1.Controls.Add(this.tbx_pubYear);
            this.groupBox1.Controls.Add(this.lbl_PubYear);
            this.groupBox1.Controls.Add(this.tbx_title);
            this.groupBox1.Controls.Add(this.lbl_Title);
            this.groupBox1.Controls.Add(this.tbx_ISBN);
            this.groupBox1.Controls.Add(this.lbl_ISBN);
            this.groupBox1.Location = new System.Drawing.Point(14, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1163, 285);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Book Information";
            // 
            // tbx_authors
            // 
            this.tbx_authors.Location = new System.Drawing.Point(139, 149);
            this.tbx_authors.Name = "tbx_authors";
            this.tbx_authors.Size = new System.Drawing.Size(947, 30);
            this.tbx_authors.TabIndex = 19;
            this.tbx_authors.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // lbl_authors
            // 
            this.lbl_authors.AutoSize = true;
            this.lbl_authors.Location = new System.Drawing.Point(13, 155);
            this.lbl_authors.Name = "lbl_authors";
            this.lbl_authors.Size = new System.Drawing.Size(78, 24);
            this.lbl_authors.TabIndex = 18;
            this.lbl_authors.Text = "Authors";
            this.lbl_authors.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(19, 458);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1169, 485);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // lbl_publisher
            // 
            this.lbl_publisher.AutoSize = true;
            this.lbl_publisher.Location = new System.Drawing.Point(13, 204);
            this.lbl_publisher.Name = "lbl_publisher";
            this.lbl_publisher.Size = new System.Drawing.Size(90, 24);
            this.lbl_publisher.TabIndex = 17;
            this.lbl_publisher.Text = "Publisher";
            // 
            // cbx_publisher
            // 
            this.cbx_publisher.FormattingEnabled = true;
            this.cbx_publisher.Location = new System.Drawing.Point(136, 200);
            this.cbx_publisher.Name = "cbx_publisher";
            this.cbx_publisher.Size = new System.Drawing.Size(273, 32);
            this.cbx_publisher.TabIndex = 6;
            // 
            // tbx_QOH
            // 
            this.tbx_QOH.Location = new System.Drawing.Point(850, 91);
            this.tbx_QOH.Name = "tbx_QOH";
            this.tbx_QOH.Size = new System.Drawing.Size(237, 30);
            this.tbx_QOH.TabIndex = 16;
            // 
            // lbl_QOH
            // 
            this.lbl_QOH.AutoSize = true;
            this.lbl_QOH.Location = new System.Drawing.Point(747, 97);
            this.lbl_QOH.Name = "lbl_QOH";
            this.lbl_QOH.Size = new System.Drawing.Size(54, 24);
            this.lbl_QOH.TabIndex = 15;
            this.lbl_QOH.Text = "QOH";
            // 
            // tbx_uPrice
            // 
            this.tbx_uPrice.Location = new System.Drawing.Point(464, 91);
            this.tbx_uPrice.Name = "tbx_uPrice";
            this.tbx_uPrice.Size = new System.Drawing.Size(155, 30);
            this.tbx_uPrice.TabIndex = 14;
            // 
            // lbl_uPrice
            // 
            this.lbl_uPrice.AutoSize = true;
            this.lbl_uPrice.Location = new System.Drawing.Point(365, 97);
            this.lbl_uPrice.Name = "lbl_uPrice";
            this.lbl_uPrice.Size = new System.Drawing.Size(93, 24);
            this.lbl_uPrice.TabIndex = 13;
            this.lbl_uPrice.Text = "Unit Price";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(849, 37);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(237, 30);
            this.textBox2.TabIndex = 8;
            // 
            // lbl_category
            // 
            this.lbl_category.AutoSize = true;
            this.lbl_category.Location = new System.Drawing.Point(746, 43);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(89, 24);
            this.lbl_category.TabIndex = 7;
            this.lbl_category.Text = "Category";
            // 
            // tbx_pubYear
            // 
            this.tbx_pubYear.Location = new System.Drawing.Point(138, 97);
            this.tbx_pubYear.Name = "tbx_pubYear";
            this.tbx_pubYear.Size = new System.Drawing.Size(150, 30);
            this.tbx_pubYear.TabIndex = 6;
            // 
            // lbl_PubYear
            // 
            this.lbl_PubYear.AutoSize = true;
            this.lbl_PubYear.Location = new System.Drawing.Point(12, 103);
            this.lbl_PubYear.Name = "lbl_PubYear";
            this.lbl_PubYear.Size = new System.Drawing.Size(116, 24);
            this.lbl_PubYear.TabIndex = 5;
            this.lbl_PubYear.Text = "Publish Year";
            // 
            // FrmBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 955);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "FrmBook";
            this.Text = "Book Record";
            this.Load += new System.EventHandler(this.FrmBook_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Label lbl_ISBN;
        private TextBox tbx_ISBN;
        private Label lbl_Title;
        private TextBox tbx_title;
        private GroupBox groupBox1;
        private TextBox textBox2;
        private Label lbl_category;
        private TextBox tbx_pubYear;
        private Label lbl_PubYear;
        private Label lbl_publisher;
        private TextBox tbx_QOH;
        private Label lbl_QOH;
        private TextBox tbx_uPrice;
        private Label lbl_uPrice;
        private ComboBox cbx_publisher;
        private TextBox tbx_authors;
        private Label lbl_authors;
        private GroupBox groupBox2;
    }
}