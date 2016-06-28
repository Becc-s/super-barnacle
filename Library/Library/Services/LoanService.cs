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
    public class LoanService : IService
    {
        LoanRepository _loanRepository;
        BookCopyRepository _bookCopyRepository;

        public LoanService(RepositoryFactory repoFactory)
        {
            _bookCopyRepository = repoFactory.GetBookCopyRepository();
            _loanRepository = repoFactory.GetLoanRepository();
        }

        public IEnumerable<Loan> All()
        {
            return _loanRepository.All();
        }
        public void Add(Loan loan)
        {
            EventArgs ev = new EventArgs();
            _loanRepository.Add(loan);
            OnChanged(this, ev);
        }

        public void Remove(Loan loan)
        {
            EventArgs ev = new EventArgs();
            _loanRepository.Remove(loan);
            OnChanged(this, ev);
        }
        public IEnumerable<Loan> GetLoansByMember(Member member)
        {
            var getloans = from loan in _loanRepository.All()
                           where loan.Member == member
                           select loan;
            return getloans;
        }

        //All available copies
        public IEnumerable<BookCopy> AllAvailableCopies()
        {
            IEnumerable<BookCopy> copies = _bookCopyRepository.All();
            IEnumerable<Loan> loan = _loanRepository.All();

            var loanedbooks = from c in copies
                              from l in loan
                              where c.Id == l.BookCopy.Id
                              select c;
            return copies.Except(loanedbooks);
        }

        public event EventHandler Updated;

        public virtual void OnChanged(Object sender, EventArgs e)
        {
            if (Updated != null)
                Updated(this, e);
        }

        //Calculates fee of a book that has passed due date
        public int CalculateFee(Loan loan)
        {

            DateTime timeOfReturn = loan.ReturnTime.Value;
            DateTime dueTime = loan.DueDate.Value;

            if (timeOfReturn != null && dueTime != null)
            {
                var diff = (timeOfReturn - dueTime);

                int resultat = diff.Days;

                if (timeOfReturn > dueTime)
                {
                    resultat *= 10;
                }

                return resultat;

            }
            throw new Exception("error");


        }

      
       

        
    }
}