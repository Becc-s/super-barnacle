//Rebecka Åkhagen Holm
//V. 1.0
using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
    public class BookCopyService : IService
    {
        BookCopyRepository _bookCopyRepository;
        LoanRepository _loanRepository;

        public BookCopyService(RepositoryFactory repoFactory)
        {
            _bookCopyRepository = repoFactory.GetBookCopyRepository();
            _loanRepository = repoFactory.GetLoanRepository();
        }

        public IEnumerable<BookCopy> All()
        {
            return _bookCopyRepository.All();
        }

        public void Add(BookCopy bookcopy)
        {
            EventArgs ev = new EventArgs();
            _bookCopyRepository.Add(bookcopy);
            OnChanged(this, ev);
        }

        public void Remove(BookCopy bokcopy)
        {
            EventArgs ev = new EventArgs();
            _bookCopyRepository.Remove(bokcopy);
            OnChanged(this, ev);
        }
        public event EventHandler Updated;

        public IEnumerable<BookCopy> GetAvaibleBooks()
        {
            IEnumerable<BookCopy> copies = _bookCopyRepository.All();
            IEnumerable<Loan> loan = _loanRepository.All();

            var loanedbooks = from c in copies
                              from l in loan
                              where c.Id == l.BookCopy.Id
                              select c;
            return copies.Except(loanedbooks);
        }

        //public IEnumerable<BookCopy> GetAvaibleBooks(IEnumerable<Loan> loans)
        //{
        //    var getcopies = from copy in _bookCopyRepository.All() //All copies
        //                    select copy;

        //    var getloans = from loan in loans //All loans
        //                   select loan.BookCopy;

        //    var reject = getcopies.Where(i => getloans.Contains(i)); //Kopier of the loaned books

        //    var result = getcopies.Except(reject); //All the copies that arent loaned 

        //    return result;
        //}

        public virtual void OnChanged(Object sender, EventArgs e)
        {
            if (Updated != null)
                Updated(this, e);
        }
    }
}
