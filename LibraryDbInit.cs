//Rebecka Åkhagen Holm
//V. 1.0
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models {
    /// <summary>
    /// Derived database strategy
    /// </summary>
    class LibraryDbInit : DropCreateDatabaseAlways<LibraryContext> {
        protected override void Seed(LibraryContext context) {
            base.Seed(context);

          
          //Add to database
            Author Rebecka = new Author() { Name = "Rebecka" };
            Book monteCristo = new Book() { Title = "The Count of Monte Cristo", Author = Rebecka, Description = "Greven av monte christo" };
            BookCopy kopia = new BookCopy() { Book = monteCristo };

            Member member1 = new Member() { Name = "Rebecka", PersonalId = "1992" };
            Loan loan1 = new Loan() { Member = member1, BookCopy = kopia };

            context.Books.Add(monteCristo);
            context.BookCopies.Add(kopia);
            context.Authors.Add(Rebecka);
            monteCristo.BookCopies.Add(kopia);
            context.SaveChanges();
            context.Members.Add(member1);
            //context.Loans.Add(loan1);
           
            

      
            // Add the book to the DbSet of books.
            

            // Persist changes to the database
            context.SaveChanges();
        }
    }
}
