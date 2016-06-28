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
    public partial class BookForm : Form
    {

        LibraryContext db = new LibraryContext();
        Book boken = new Book();
        BookService _bookService;
        AuthorService _authorService;
        BookCopyService _bookCopyService;

        

        
        

        public BookForm(AuthorService aa, BookService bb, BookCopyService bc)
        {
            InitializeComponent();
            RepositoryFactory repoFactory = new RepositoryFactory();

            _bookService = bb;
            _authorService = aa;
            _bookCopyService = bc;

            _authorService.Updated += ListAllAuthors;

            _authorService.OnChanged(this, EventArgs.Empty);
       
        }
        
        //Add book
        private void btAddBook_Click(object sender, EventArgs e)
        {     
            
            string ISBN = txtIsbn.Text;
            Book bok1 = new Book();
            BookCopy kopia1 = new BookCopy();
            bok1.Description = txtDescription.Text;
            bok1.Title = txtTitle.Text;
            int isbn = bok1.ISBN;
            bool isAInt = int.TryParse(ISBN, out isbn);
            bok1.Author = (Author)lbBooksByAuthor.SelectedItem;
            kopia1.Book = bok1;
            

            if(bok1.Author != null && txtDescription.Text != null && txtIsbn.Text != null && isAInt == true)
            {
                LibraryForm library = new LibraryForm();
                _bookService.Add(bok1);
                _bookCopyService.Add(kopia1);
          
                this.Close();
                 
            }
            else{


                MessageBox.Show("You have to select an author and add description. ISBN have to be a number");
            }

          
                    
        }


        public void ListAllAuthors(object sender, EventArgs e)
        {
            lbBooksByAuthor.Items.Clear();

            foreach (Author author in _authorService.All())
            {
                lbBooksByAuthor.Items.Add(author);
            }
        }
    }
}
