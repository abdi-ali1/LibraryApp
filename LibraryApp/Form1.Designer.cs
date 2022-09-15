namespace LibraryApp
{
    partial class Form1
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbLibrary = new System.Windows.Forms.ListBox();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.tbId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnAvailable = new System.Windows.Forms.RadioButton();
            this.rbtnBorrowed = new System.Windows.Forms.RadioButton();
            this.btnShowBooksThatAre = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbAvailability = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.rbtnMiscellaneous = new System.Windows.Forms.RadioButton();
            this.rbtnDatabase = new System.Windows.Forms.RadioButton();
            this.rbtnProgramming = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAuthor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbLibrary);
            this.groupBox3.Controls.Add(this.btnBorrow);
            this.groupBox3.Controls.Add(this.btnReturn);
            this.groupBox3.Controls.Add(this.btnRemove);
            this.groupBox3.Controls.Add(this.tbId);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(307, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(496, 324);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Library Management";
            // 
            // lbLibrary
            // 
            this.lbLibrary.FormattingEnabled = true;
            this.lbLibrary.Location = new System.Drawing.Point(6, 23);
            this.lbLibrary.Name = "lbLibrary";
            this.lbLibrary.Size = new System.Drawing.Size(484, 212);
            this.lbLibrary.TabIndex = 5;
            this.lbLibrary.SelectedIndexChanged += new System.EventHandler(this.lbLibrary_SelectedIndexChanged);
            // 
            // btnBorrow
            // 
            this.btnBorrow.Location = new System.Drawing.Point(398, 286);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(92, 23);
            this.btnBorrow.TabIndex = 4;
            this.btnBorrow.Text = "Borrow";
            this.btnBorrow.UseVisualStyleBackColor = true;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(300, 286);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(92, 23);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(59, 284);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(59, 258);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(75, 20);
            this.tbId.TabIndex = 1;
            this.tbId.Text = "100";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnAvailable);
            this.groupBox2.Controls.Add(this.rbtnBorrowed);
            this.groupBox2.Controls.Add(this.btnShowBooksThatAre);
            this.groupBox2.Controls.Add(this.btnShowAll);
            this.groupBox2.Location = new System.Drawing.Point(12, 248);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(289, 88);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Show Books";
            // 
            // rbtnAvailable
            // 
            this.rbtnAvailable.AutoSize = true;
            this.rbtnAvailable.Location = new System.Drawing.Point(215, 56);
            this.rbtnAvailable.Name = "rbtnAvailable";
            this.rbtnAvailable.Size = new System.Drawing.Size(68, 17);
            this.rbtnAvailable.TabIndex = 3;
            this.rbtnAvailable.Text = "Available";
            this.rbtnAvailable.UseVisualStyleBackColor = true;
            // 
            // rbtnBorrowed
            // 
            this.rbtnBorrowed.AutoSize = true;
            this.rbtnBorrowed.Checked = true;
            this.rbtnBorrowed.Location = new System.Drawing.Point(139, 56);
            this.rbtnBorrowed.Name = "rbtnBorrowed";
            this.rbtnBorrowed.Size = new System.Drawing.Size(70, 17);
            this.rbtnBorrowed.TabIndex = 2;
            this.rbtnBorrowed.TabStop = true;
            this.rbtnBorrowed.Text = "Borrowed";
            this.rbtnBorrowed.UseVisualStyleBackColor = true;
            // 
            // btnShowBooksThatAre
            // 
            this.btnShowBooksThatAre.Location = new System.Drawing.Point(7, 50);
            this.btnShowBooksThatAre.Name = "btnShowBooksThatAre";
            this.btnShowBooksThatAre.Size = new System.Drawing.Size(126, 23);
            this.btnShowBooksThatAre.TabIndex = 1;
            this.btnShowBooksThatAre.Text = "Show Books That Are";
            this.btnShowBooksThatAre.UseVisualStyleBackColor = true;
            this.btnShowBooksThatAre.Click += new System.EventHandler(this.btnShowBooksThatAre_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(7, 20);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(126, 23);
            this.btnShowAll.TabIndex = 0;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbAvailability);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.rbtnMiscellaneous);
            this.groupBox1.Controls.Add(this.rbtnDatabase);
            this.groupBox1.Controls.Add(this.rbtnProgramming);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbAuthor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbTitle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 230);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Book";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Availability";
            // 
            // tbAvailability
            // 
            this.tbAvailability.Location = new System.Drawing.Point(89, 171);
            this.tbAvailability.Name = "tbAvailability";
            this.tbAvailability.Size = new System.Drawing.Size(44, 20);
            this.tbAvailability.TabIndex = 9;
            this.tbAvailability.Text = "2";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(22, 201);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(261, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // rbtnMiscellaneous
            // 
            this.rbtnMiscellaneous.AutoSize = true;
            this.rbtnMiscellaneous.Location = new System.Drawing.Point(89, 138);
            this.rbtnMiscellaneous.Name = "rbtnMiscellaneous";
            this.rbtnMiscellaneous.Size = new System.Drawing.Size(115, 17);
            this.rbtnMiscellaneous.TabIndex = 7;
            this.rbtnMiscellaneous.Text = "MISCELLANEOUS";
            this.rbtnMiscellaneous.UseVisualStyleBackColor = true;
            // 
            // rbtnDatabase
            // 
            this.rbtnDatabase.AutoSize = true;
            this.rbtnDatabase.Location = new System.Drawing.Point(89, 115);
            this.rbtnDatabase.Name = "rbtnDatabase";
            this.rbtnDatabase.Size = new System.Drawing.Size(82, 17);
            this.rbtnDatabase.TabIndex = 6;
            this.rbtnDatabase.Text = "DATABASE";
            this.rbtnDatabase.UseVisualStyleBackColor = true;
            // 
            // rbtnProgramming
            // 
            this.rbtnProgramming.AutoSize = true;
            this.rbtnProgramming.Checked = true;
            this.rbtnProgramming.Location = new System.Drawing.Point(89, 92);
            this.rbtnProgramming.Name = "rbtnProgramming";
            this.rbtnProgramming.Size = new System.Drawing.Size(108, 17);
            this.rbtnProgramming.TabIndex = 5;
            this.rbtnProgramming.TabStop = true;
            this.rbtnProgramming.Text = "PROGRAMMING";
            this.rbtnProgramming.UseVisualStyleBackColor = true;
            this.rbtnProgramming.CheckedChanged += new System.EventHandler(this.rbtnProgramming_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Book Type";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbAuthor
            // 
            this.tbAuthor.Location = new System.Drawing.Point(89, 54);
            this.tbAuthor.Name = "tbAuthor";
            this.tbAuthor.Size = new System.Drawing.Size(194, 20);
            this.tbAuthor.TabIndex = 3;
            this.tbAuthor.Text = "Andrew Stelleman";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Author";
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(89, 20);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(194, 20);
            this.tbTitle.TabIndex = 1;
            this.tbTitle.Text = "Head First C#";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 345);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lbLibrary;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtnAvailable;
        private System.Windows.Forms.RadioButton rbtnBorrowed;
        private System.Windows.Forms.Button btnShowBooksThatAre;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbAvailability;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.RadioButton rbtnMiscellaneous;
        private System.Windows.Forms.RadioButton rbtnDatabase;
        private System.Windows.Forms.RadioButton rbtnProgramming;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAuthor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Label label1;
    }
}

