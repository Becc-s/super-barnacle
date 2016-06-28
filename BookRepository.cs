//Rebecka Åkhagen Holm
//V. 1.0
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Models;

namespace Library.Repositories {
    public class BookRepository : IRepository<Book, int> {
        LibraryContext _context;

        public BookRepository(LibraryContext ctx) {
            _context = ctx;
        }

        public IEnumerable<Book> All() {
            return _context.Books.ToList();
        }

        public void Add(Book item)
        {
            _context.Books.Add(item);
            _context.SaveChanges();
        }

        public void Remove(Book item)
        {
            _context.Books.Remove(item);
            _context.SaveChanges();
       
        }

        public Book Find(int id)
        {
            return _context.Books.Find(id);
        }

        public void Edit(Book item)
        {
            throw new NotImplementedException();
        }
    }
}