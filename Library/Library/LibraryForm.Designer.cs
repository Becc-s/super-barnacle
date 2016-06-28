namespace Library {
    partial class LibraryForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lbBooks = new System.Windows.Forms.ListBox();
            this.lbAuthors = new System.Windows.Forms.ListBox();
            this.lbMembers = new System.Windows.Forms.ListBox();
            this.lbLoans = new System.Windows.Forms.ListBox();
            this.lbCopies = new System.Windows.Forms.ListBox();
            this.btnNewBook = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnNewAuthor = new System.Windows.Forms.Button();
            this.btnLoan = new System.Windows.Forms.Button();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.btnNewMember = new System.Windows.Forms.Button();
            this.btnRemoveBook = new System.Windows.Forms.Button();
            this.btnBooksByAuthor = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbOldLoans = new System.Windows.Forms.ListBox();
            this.btnReturnBook = new System.Windows.Forms.Button();
            this.btnLoanByMember = new System.Windows.Forms.Button();
            this.lbLoansByMember = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtPrintDescription = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditBook = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbBooks
            // 
            this.lbBooks.FormattingEnabled = true;
            this.lbBooks.Location = new System.Drawing.Point(49, 377);
            this.lbBooks.Name = "lbBooks";
            this.lbBooks.Size = new System.Drawing.Size(260, 95);
            this.lbBooks.TabIndex = 0;
            this.lbBooks.SelectedIndexChanged += new System.EventHandler(this.lbBooks_SelectedIndexChanged);
            // 
            // lbAuthors
            // 
            this.lbAuthors.FormattingEnabled = true;
            this.lbAuthors.Location = new System.Drawing.Point(49, 46);
            this.lbAuthors.Name = "lbAuthors";
            this.lbAuthors.Size = new System.Drawing.Size(260, 82);
            this.lbAuthors.TabIndex = 1;
            // 
            // lbMembers
            // 
            this.lbMembers.FormattingEnabled = true;
            this.lbMembers.Location = new System.Drawing.Point(23, 35);
            this.lbMembers.Name = "lbMembers";
            this.lbMembers.Size = new System.Drawing.Size(268, 82);
            this.lbMembers.TabIndex = 2;
            // 
            // lbLoans
            // 
            this.lbLoans.FormattingEnabled = true;
            this.lbLoans.Location = new System.Drawing.Point(335, 40);
            this.lbLoans.Name = "lbLoans";
            this.lbLoans.Size = new System.Drawing.Size(275, 95);
            this.lbLoans.TabIndex = 3;
            // 
            // lbCopies
            // 
            this.lbCopies.FormattingEnabled = true;
            this.lbCopies.Location = new System.Drawing.Point(23, 179);
            this.lbCopies.Name = "lbCopies";
            this.lbCopies.Size = new System.Drawing.Size(268, 82);
            this.lbCopies.TabIndex = 4;
            // 
            // btnNewBook
            // 
            this.btnNewBook.Location = new System.Drawing.Point(27, 251);
            this.btnNewBook.Name = "btnNewBook";
            this.btnNewBook.Size = new System.Drawing.Size(75, 23);
            this.btnNewBook.TabIndex = 5;
            this.btnNewBook.Text = "New book";
            this.btnNewBook.UseVisualStyleBackColor = true;
            this.btnNewBook.Click += new System.EventHandler(this.btnNewBook_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Books";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Aviable book copies";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(332, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Loans";
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(27, 222);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 11;
            this.btnCopy.Text = "Buy copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnNewAuthor
            // 
            this.btnNewAuthor.Location = new System.Drawing.Point(27, 216);
            this.btnNewAuthor.Name = "btnNewAuthor";
            this.btnNewAuthor.Size = new System.Drawing.Size(111, 23);
            this.btnNewAuthor.TabIndex = 12;
            this.btnNewAuthor.Text = "Add new author";
            this.btnNewAuthor.UseVisualStyleBackColor = true;
            this.btnNewAuthor.Click += new System.EventHandler(this.btnNewAuthor_Click);
            // 
            // btnLoan
            // 
            this.btnLoan.Location = new System.Drawing.Point(23, 267);
            this.btnLoan.Name = "btnLoan";
            this.btnLoan.Size = new System.Drawing.Size(75, 23);
            this.btnLoan.TabIndex = 13;
            this.btnLoan.Text = "Loan book";
            this.btnLoan.UseVisualStyleBackColor = true;
            this.btnLoan.Click += new System.EventHandler(this.btnLoan_Click);
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(27, 190);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(260, 20);
            this.txtAuthor.TabIndex = 14;
            this.txtAuthor.Text = "Author name";
            // 
            // btnNewMember
            // 
            this.btnNewMember.Location = new System.Drawing.Point(23, 123);
            this.btnNewMember.Name = "btnNewMember";
            this.btnNewMember.Size = new System.Drawing.Size(93, 23);
            this.btnNewMember.TabIndex = 15;
            this.btnNewMember.Text = "New Member";
            this.btnNewMember.UseVisualStyleBackColor = true;
            this.btnNewMember.Click += new System.EventHandler(this.btnNewMember_Click);
            // 
            // btnRemoveBook
            // 
            this.btnRemoveBook.Location = new System.Drawing.Point(121, 222);
            this.btnRemoveBook.Name = "btnRemoveBook";
            this.btnRemoveBook.Size = new System.Drawing.Size(89, 23);
            this.btnRemoveBook.TabIndex = 16;
            this.btnRemoveBook.Text = "Remove book";
            this.btnRemoveBook.UseVisualStyleBackColor = true;
            this.btnRemoveBook.Click += new System.EventHandler(this.btnRemoveBook_Click);
            // 
            // btnBooksByAuthor
            // 
            this.btnBooksByAuthor.Location = new System.Drawing.Point(27, 123);
            this.btnBooksByAuthor.Name = "btnBooksByAuthor";
            this.btnBooksByAuthor.Size = new System.Drawing.Size(160, 23);
            this.btnBooksByAuthor.TabIndex = 17;
            this.btnBooksByAuthor.Text = "Show books by author";
            this.btnBooksByAuthor.UseVisualStyleBackColor = true;
            this.btnBooksByAuthor.Click += new System.EventHandler(this.btnBooksByAuthor_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEditBook);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPrintDescription);
            this.groupBox1.Controls.Add(this.btnRemoveBook);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnCopy);
            this.groupBox1.Controls.Add(this.lbLoans);
            this.groupBox1.Controls.Add(this.btnNewBook);
            this.groupBox1.Location = new System.Drawing.Point(22, 337);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(683, 283);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "All loans and books";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbOldLoans);
            this.groupBox2.Controls.Add(this.btnReturnBook);
            this.groupBox2.Controls.Add(this.btnLoanByMember);
            this.groupBox2.Controls.Add(this.lbLoansByMember);
            this.groupBox2.Controls.Add(this.btnNewMember);
            this.groupBox2.Controls.Add(this.btnLoan);
            this.groupBox2.Controls.Add(this.lbMembers);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lbCopies);
            this.groupBox2.Location = new System.Drawing.Point(334, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(663, 320);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "New members and loans";
            // 
            // lbOldLoans
            // 
            this.lbOldLoans.FormattingEnabled = true;
            this.lbOldLoans.Location = new System.Drawing.Point(354, 179);
            this.lbOldLoans.Name = "lbOldLoans";
            this.lbOldLoans.Size = new System.Drawing.Size(275, 82);
            this.lbOldLoans.TabIndex = 22;
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.Location = new System.Drawing.Point(354, 123);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Size = new System.Drawing.Size(75, 23);
            this.btnReturnBook.TabIndex = 20;
            this.btnReturnBook.Text = "Return book";
            this.btnReturnBook.UseVisualStyleBackColor = true;
            this.btnReturnBook.Click += new System.EventHandler(this.btnReturnBook_Click);
            // 
            // btnLoanByMember
            // 
            this.btnLoanByMember.Location = new System.Drawing.Point(153, 123);
            this.btnLoanByMember.Name = "btnLoanByMember";
            this.btnLoanByMember.Size = new System.Drawing.Size(125, 23);
            this.btnLoanByMember.TabIndex = 16;
            this.btnLoanByMember.Text = "Show loan by member";
            this.btnLoanByMember.UseVisualStyleBackColor = true;
            this.btnLoanByMember.Click += new System.EventHandler(this.btnLoanByMember_Click);
            // 
            // lbLoansByMember
            // 
            this.lbLoansByMember.FormattingEnabled = true;
            this.lbLoansByMember.Location = new System.Drawing.Point(354, 35);
            this.lbLoansByMember.Name = "lbLoansByMember";
            this.lbLoansByMember.Size = new System.Drawing.Size(275, 82);
            this.lbLoansByMember.TabIndex = 21;
            this.lbLoansByMember.SelectedIndexChanged += new System.EventHandler(this.lbLoansByMember_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnBooksByAuthor);
            this.groupBox3.Controls.Add(this.btnNewAuthor);
            this.groupBox3.Controls.Add(this.txtAuthor);
            this.groupBox3.Location = new System.Drawing.Point(22, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(306, 320);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Authors";
            // 
            // txtPrintDescription
            // 
            this.txtPrintDescription.Location = new System.Drawing.Point(27, 171);
            this.txtPrintDescription.Name = "txtPrintDescription";
            this.txtPrintDescription.ReadOnly = true;
            this.txtPrintDescription.Size = new System.Drawing.Size(260, 20);
            this.txtPrintDescription.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Book description";
        
    
            // LibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 677);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbAuthors);
            this.Controls.Add(this.lbBooks);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "LibraryForm";
            this.Text = "Library";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbBooks;
        private System.Windows.Forms.ListBox lbAuthors;
        private System.Windows.Forms.ListBox lbMembers;
        private System.Windows.Forms.ListBox lbLoans;
        private System.Windows.Forms.ListBox lbCopies;
        private System.Windows.Forms.Button btnNewBook;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnNewAuthor;
        private System.Windows.Forms.Button btnLoan;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Button btnNewMember;
        private System.Windows.Forms.Button btnRemoveBook;
        private System.Windows.Forms.Button btnBooksByAuthor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLoanByMember;
        private System.Windows.Forms.Button btnReturnBook;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lbLoansByMember;
        private System.Windows.Forms.ListBox lbOldLoans;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtPrintDescription;
        private System.Windows.Forms.Button btnEditBook;
    }
}

