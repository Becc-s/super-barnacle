//Rebecka Åkhagen Holm
//V. 1.0
using Library.Models;
using Library.Repositories;
using Library.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class LibraryForm : Form
    {

        BookService _bookService;
        BookCopyService _bookCopyService;
        AuthorService _authorService;
        LoanService _loanService;
        MemberService _memberService;




        public LibraryForm()
        {
            InitializeComponent();

            RepositoryFactory repoFactory = new RepositoryFactory();

            _bookService = new BookService(repoFactory);
            _bookCopyService = new BookCopyService(repoFactory);
            _authorService = new AuthorService(repoFactory);
            _loanService = new LoanService(repoFactory);
            _memberService = new MemberService(repoFactory);


            //Subscribe to event
            _bookService.Updated += ListAllBooks;
            _bookCopyService.Updated += ListAllBookCopies;
            _authorService.Updated += ListAllAuthors;
            _loanService.Updated += ListAllLoans;
            _memberService.Updated += ListAllMembers;

            //Call the event to print to print the "test-objects"
            _authorService.OnChanged(this, EventArgs.Empty);
            _bookService.OnChanged(this, EventArgs.Empty);
            _bookCopyService.OnChanged(this, EventArgs.Empty);
            _loanService.OnChanged(this, EventArgs.Empty);
            _memberService.OnChanged(this, EventArgs.Empty);


        }

        //All print methods that are subscribed to the event

        public void ListAllBooks(object sender, EventArgs e)
        {

            lbBooks.Items.Clear();

            foreach (Book book in _bookService.All())
            {
                lbBooks.Items.Add(book);
            }
        }

        public void ListAllBookCopies(object sender, EventArgs e)
        {
            lbCopies.Items.Clear();

            foreach (BookCopy copybook in _loanService.AllAvailableCopies()) //All available copies.
            {
                lbCopies.Items.Add(copybook);
            }
        }

        public void ListAllAuthors(object sender, EventArgs e)
        {
            lbAuthors.Items.Clear();

            foreach (Author author in _authorService.All())
            {
                lbAuthors.Items.Add(author);
            }
        }

        private void ListAllLoans(object sender, EventArgs e)
        {
            lbLoans.Items.Clear();

            foreach (Loan loan in _loanService.All())
            {
                lbLoans.Items.Add(loan);
            }
        }

        public void ListAllMembers(object sender, EventArgs e)
        {
            lbMembers.Items.Clear();

            foreach (Member member in _memberService.All())
            {
                lbMembers.Items.Add(member);
            }
        }

        private void btnNewBook_Click(object sender, EventArgs e)
        {
            //Form where you add a new book
            BookForm bokform = new BookForm(_authorService, _bookService, _bookCopyService);
            bokform.ShowDialog();

        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            BookCopy kopia = new BookCopy();

            //Buy a copy of a selected book from the list
            if (lbBooks.SelectedItem != null)
            {
                kopia.Book = (Book)lbBooks.SelectedItem;
                _bookCopyService.Add(kopia);
                _bookCopyService.OnChanged(this, EventArgs.Empty);
                
            }
            else
            {
                MessageBox.Show("You have to select a book to make a copy!");
            }

        }

        private void btnNewAuthor_Click(object sender, EventArgs e)
        {
            Author a1 = new Author();

            if(txtAuthor.Text != null)
            {
                a1.Name = txtAuthor.Text;
                _authorService.Add(a1);
                _authorService.OnChanged(this, EventArgs.Empty);
                txtAuthor.Clear();
            }
            else
            {
                MessageBox.Show("Yoy have not given an input!");
            }
            
        }

        private void btnNewMember_Click(object sender, EventArgs e)
        {
            MemberForm member = new MemberForm(_memberService);
            member.ShowDialog();
        }

        //Remove a selected book from the list
        private void btnRemoveBook_Click(object sender, EventArgs e)
        {
     
            Book bok = (Book)lbBooks.SelectedItem;
            var lista = bok.BookCopies.ToList();

            foreach (var item in lista)
            {
                _bookCopyService.Remove(item);
                txtPrintDescription.Text = "";
            }

            _bookService.Remove(bok);
      
        }


        //Sort book by author
        private void btnBooksByAuthor_Click(object sender, EventArgs e)
        {
            if(lbAuthors.SelectedItem != null)
            {
                Author a1 = new Author();
                a1 = (Author)lbAuthors.SelectedItem;
                lbBooks.Items.Clear();
                lbBooks.Items.AddRange(_bookService.GetBooksByAuthor(a1).ToArray());

            }
            else
            {
                MessageBox.Show("You have to select an author");
            }
            
        }

        //Method to update loans my member by using a linq method
        private void UpdateMemberLoan()
        {
            lbLoansByMember.Items.Clear();
            Member m1 = new Member();
            m1 = (Member)lbMembers.SelectedItem;     
            lbLoansByMember.Items.AddRange(_loanService.GetLoansByMember(m1).ToArray());
            
        }

        private void btnLoan_Click(object sender, EventArgs e)
        {
            if(lbCopies.SelectedItem != null && lbMembers.SelectedItem != null)
            {
                Loan l1 = new Loan();
                l1.BookCopy = (BookCopy)lbCopies.SelectedItem;
                l1.Member = (Member)lbMembers.SelectedItem;

                //set time of loan to today's date
                l1.TimeofLoan = DateTime.Now;
                l1.ReturnTime = null;
                //due date will be set as 15 days
                DateTime time = DateTime.Today.AddDays(15);
                l1.DueDate = time;

                _loanService.Add(l1);
                _bookCopyService.OnChanged(this, EventArgs.Empty);
                         
              
            }
            else
            {
                MessageBox.Show("You have to select a member and a bookcopy");
            }
            
        }

       
         

        

        private void btnLoanByMember_Click(object sender, EventArgs e)
        {
            if(lbMembers.SelectedItem != null)
            {
                UpdateMemberLoan();
            }
            else
            {
                MessageBox.Show("You have not selected a member");
            }


        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            Loan l1 = new Loan();
            l1 = (Loan)lbLoansByMember.SelectedItem;
            //set returndate to a month to see if the loan has passed due date
            l1.ReturnTime = DateTime.Today.AddMonths(1);

            if (lbLoansByMember.SelectedItem != null)
            {
                //call the method wich calculates the fee for a book that is late
                var fee = _loanService.CalculateFee(l1);
                lbOldLoans.Items.Add(l1.BookCopy + " ----> Fee = " + fee + " kr");
                _loanService.Remove(l1);
                UpdateMemberLoan();
                _bookCopyService.OnChanged(this, EventArgs.Empty);

            }

            else
            {
                MessageBox.Show("You have to select a loan by member");
            }


        }

        private void lbLoansByMember_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbLoansByMember.SelectedItem != null)
            {
                btnReturnBook.Enabled = true;
            }
            else
            {
                btnReturnBook.Enabled = false;
            }
        }

        private void lbBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            Book b1 = new Book();
            b1 = (Book)lbBooks.SelectedItem;

            if(lbBooks.SelectedItem != null)
            {
                txtPrintDescription.Text = b1.Description;
            }
        }

   
    }
}

       


      

       

      
    

