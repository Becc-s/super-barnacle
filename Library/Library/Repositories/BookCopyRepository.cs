//Rebecka Åkhagen Holm
//V. 1.0
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Models;

namespace Library.Repositories
{
    public class BookCopyRepository : IRepository<BookCopy, int>
    {
        LibraryContext _context;

        public BookCopyRepository(LibraryContext ctx)
        {
            _context = ctx;
        }

        public IEnumerable<BookCopy> All()
        {
            return _context.BookCopies.ToList();
        }

        public void Add(BookCopy item)
        {
            _context.BookCopies.Add(item);
             _context.SaveChanges();
        }

        public void Remove(BookCopy item)
        {
                _context.BookCopies.Remove(item);
                _context.SaveChanges();
        }

        public BookCopy Find(int id)
        {
            return _context.BookCopies.Find(id);
        }

        public void Edit(BookCopy item)
        {
            throw new NotImplementedException();
        }

    }
}