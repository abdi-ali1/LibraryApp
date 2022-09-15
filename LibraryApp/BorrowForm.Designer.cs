namespace LibraryApp
{
    partial class BorrowForm
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
            this.btnTryToBorrow = new System.Windows.Forms.Button();
            this.lblBookInfo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbBorrowerName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnTryToBorrow
            // 
            this.btnTryToBorrow.Location = new System.Drawing.Point(199, 123);
            this.btnTryToBorrow.Name = "btnTryToBorrow";
            this.btnTryToBorrow.Size = new System.Drawing.Size(75, 23);
            this.btnTryToBorrow.TabIndex = 0;
            this.btnTryToBorrow.Text = "Borrow";
            this.btnTryToBorrow.UseVisualStyleBackColor = true;
            this.btnTryToBorrow.Click += new System.EventHandler(this.btnTryToBorrow_Click);
            // 
            // lblBookInfo
            // 
            this.lblBookInfo.AutoSize = true;
            this.lblBookInfo.Location = new System.Drawing.Point(27, 38);
            this.lblBookInfo.Name = "lblBookInfo";
            this.lblBookInfo.Size = new System.Drawing.Size(60, 13);
            this.lblBookInfo.TabIndex = 1;
            this.lblBookInfo.Text = "lblBookInfo";
            this.lblBookInfo.Click += new System.EventHandler(this.lblBookInfo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Borrower Name";
            // 
            // tbBorrowerName
            // 
            this.tbBorrowerName.Location = new System.Drawing.Point(113, 87);
            this.tbBorrowerName.Name = "tbBorrowerName";
            this.tbBorrowerName.Size = new System.Drawing.Size(346, 20);
            this.tbBorrowerName.TabIndex = 3;
            this.tbBorrowerName.TextChanged += new System.EventHandler(this.tbBorrowerName_TextChanged);
            // 
            // BorrowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 170);
            this.Controls.Add(this.tbBorrowerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblBookInfo);
            this.Controls.Add(this.btnTryToBorrow);
            this.Name = "BorrowForm";
            this.Text = "BorrowForm";
            this.Load += new System.EventHandler(this.BorrowForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTryToBorrow;
        private System.Windows.Forms.Label lblBookInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbBorrowerName;
    }
}