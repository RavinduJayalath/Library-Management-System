namespace Library
{
    partial class FOT
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
            this.btn_borrow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_borrow
            // 
            this.btn_borrow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_borrow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_borrow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_borrow.FlatAppearance.BorderSize = 0;
            this.btn_borrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_borrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_borrow.ForeColor = System.Drawing.Color.White;
            this.btn_borrow.Location = new System.Drawing.Point(898, 185);
            this.btn_borrow.Name = "btn_borrow";
            this.btn_borrow.Size = new System.Drawing.Size(217, 60);
            this.btn_borrow.TabIndex = 2;
            this.btn_borrow.Text = "Borrow";
            this.btn_borrow.UseVisualStyleBackColor = false;
            this.btn_borrow.Visible = false;
            this.btn_borrow.Click += new System.EventHandler(this.btn_borrow_Click);
            // 
            // FOT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1117, 447);
            this.Controls.Add(this.btn_borrow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FOT";
            this.Text = "FOT";
            this.Load += new System.EventHandler(this.FOT_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_borrow;
    }
}