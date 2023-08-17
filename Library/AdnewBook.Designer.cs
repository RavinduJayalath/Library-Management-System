namespace Library
{
    partial class AdnewBook
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_newbooktitle = new System.Windows.Forms.TextBox();
            this.tb_newbookFaculty = new System.Windows.Forms.ComboBox();
            this.tb_newbookAuthor = new System.Windows.Forms.TextBox();
            this.tb_newbookQty = new System.Windows.Forms.TextBox();
            this.btn_addnewbook = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 46);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(50, 50, 50, 0);
            this.panel1.Size = new System.Drawing.Size(997, 365);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.23552F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.76448F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 249F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tb_newbooktitle, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_newbookFaculty, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tb_newbookAuthor, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tb_newbookQty, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_addnewbook, 2, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(50, 50);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.81818F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.18182F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(897, 278);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 49);
            this.label2.TabIndex = 0;
            this.label2.Text = "Title";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 138);
            this.label4.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 51);
            this.label4.TabIndex = 2;
            this.label4.Text = "Qty";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 43);
            this.label3.TabIndex = 1;
            this.label3.Text = "Author";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 49);
            this.label5.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 46);
            this.label5.TabIndex = 3;
            this.label5.Text = "Faculty";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tb_newbooktitle
            // 
            this.tb_newbooktitle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tb_newbooktitle.Location = new System.Drawing.Point(147, 24);
            this.tb_newbooktitle.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.tb_newbooktitle.Name = "tb_newbooktitle";
            this.tb_newbooktitle.Size = new System.Drawing.Size(490, 22);
            this.tb_newbooktitle.TabIndex = 4;
            // 
            // tb_newbookFaculty
            // 
            this.tb_newbookFaculty.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tb_newbookFaculty.FormattingEnabled = true;
            this.tb_newbookFaculty.Items.AddRange(new object[] {
            "Faculty Of Bussiness Studies",
            "Faculty Of Applied Science",
            "Faculty Of Technology"});
            this.tb_newbookFaculty.Location = new System.Drawing.Point(147, 68);
            this.tb_newbookFaculty.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.tb_newbookFaculty.Name = "tb_newbookFaculty";
            this.tb_newbookFaculty.Size = new System.Drawing.Size(490, 24);
            this.tb_newbookFaculty.TabIndex = 5;
            // 
            // tb_newbookAuthor
            // 
            this.tb_newbookAuthor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tb_newbookAuthor.Location = new System.Drawing.Point(147, 113);
            this.tb_newbookAuthor.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.tb_newbookAuthor.Name = "tb_newbookAuthor";
            this.tb_newbookAuthor.Size = new System.Drawing.Size(490, 22);
            this.tb_newbookAuthor.TabIndex = 6;
            // 
            // tb_newbookQty
            // 
            this.tb_newbookQty.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tb_newbookQty.Location = new System.Drawing.Point(147, 164);
            this.tb_newbookQty.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.tb_newbookQty.Name = "tb_newbookQty";
            this.tb_newbookQty.Size = new System.Drawing.Size(490, 22);
            this.tb_newbookQty.TabIndex = 7;
            // 
            // btn_addnewbook
            // 
            this.btn_addnewbook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_addnewbook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addnewbook.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_addnewbook.FlatAppearance.BorderSize = 0;
            this.btn_addnewbook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addnewbook.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addnewbook.Location = new System.Drawing.Point(650, 209);
            this.btn_addnewbook.Margin = new System.Windows.Forms.Padding(3, 20, 20, 3);
            this.btn_addnewbook.Name = "btn_addnewbook";
            this.btn_addnewbook.Size = new System.Drawing.Size(227, 58);
            this.btn_addnewbook.TabIndex = 8;
            this.btn_addnewbook.Text = "Add";
            this.btn_addnewbook.UseVisualStyleBackColor = false;
            this.btn_addnewbook.Click += new System.EventHandler(this.btn_addnewbook_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(997, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add New Book to Store";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(997, 46);
            this.panel2.TabIndex = 2;
            // 
            // AdnewBook
            // 
            this.AcceptButton = this.btn_addnewbook;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 421);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdnewBook";
            this.Text = "AdnewBook";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_newbooktitle;
        private System.Windows.Forms.ComboBox tb_newbookFaculty;
        private System.Windows.Forms.TextBox tb_newbookAuthor;
        private System.Windows.Forms.TextBox tb_newbookQty;
        private System.Windows.Forms.Button btn_addnewbook;
        private System.Windows.Forms.Panel panel2;
    }
}