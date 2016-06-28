//Rebecka Åkhagen Holm
//V. 1.0
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Models;

namespace Library.Repositories
{
    public class LoanRepository : IRepository<Loan, int>
    {
        LibraryContext _context;

         public LoanRepository(LibraryContext ctx) {
            _context = ctx;
        }

        public IEnumerable<Loan> All() {
            return _context.Loans.ToList();
        }

        public void Add(Loan item)
        {
            _context.Loans.Add(item);
            _context.SaveChanges();
        }

        public void Remove(Loan item)
        {
           
            _context.Loans.Remove(item);
            _context.SaveChanges();
        
        }

        public Loan Find(int id)
        {
            return _context.Loans.Find(id);
        }

        public void Edit(Loan item)
        {
            throw new NotImplementedException();
        }

    }
}
