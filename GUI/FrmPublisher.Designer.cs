namespace BookBiz_Management_System.GUI
{
    partial class FrmPublisher
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
            this.TbxPublisherId = new System.Windows.Forms.TextBox();
            this.TbxPublisherName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.DgvPublishers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPublishers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Publisher ID";
            // 
            // TbxPublisherId
            // 
            this.TbxPublisherId.Location = new System.Drawing.Point(88, 189);
            this.TbxPublisherId.Name = "TbxPublisherId";
            this.TbxPublisherId.Size = new System.Drawing.Size(100, 23);
            this.TbxPublisherId.TabIndex = 1;
            // 
            // TbxPublisherName
            // 
            this.TbxPublisherName.Location = new System.Drawing.Point(326, 189);
            this.TbxPublisherName.Name = "TbxPublisherName";
            this.TbxPublisherName.Size = new System.Drawing.Size(100, 23);
            this.TbxPublisherName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Publisher Name";
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.Aquamarine;
            this.BtnAdd.Location = new System.Drawing.Point(464, 189);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 4;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // DgvPublishers
            // 
            this.DgvPublishers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPublishers.Location = new System.Drawing.Point(12, 12);
            this.DgvPublishers.Name = "DgvPublishers";
            this.DgvPublishers.RowTemplate.Height = 25;
            this.DgvPublishers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvPublishers.Size = new System.Drawing.Size(553, 156);
            this.DgvPublishers.TabIndex = 5;
            this.DgvPublishers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPublishers_CellDoubleClick);
            // 
            // FrmPublisher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 235);
            this.Controls.Add(this.DgvPublishers);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.TbxPublisherName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TbxPublisherId);
            this.Controls.Add(this.label1);
            this.Name = "FrmPublisher";
            this.Text = "FrmPublisher";
            ((System.ComponentModel.ISupportInitialize)(this.DgvPublishers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox TbxPublisherId;
        private TextBox TbxPublisherName;
        private Label label2;
        private Button BtnAdd;
        private DataGridView DgvPublishers;
    }
}