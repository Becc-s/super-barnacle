//Rebecka Åkhagen Holm
//V. 1.0
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Models;

namespace Library.Repositories
{
    public class AuthorRepository : IRepository<Author, int>
    {
         LibraryContext _context;

        public AuthorRepository(LibraryContext ctx) {
            _context = ctx;
        }

        public IEnumerable<Author> All() {
            return _context.Authors.ToList();
        }

        public void Add(Author item)
        {
            _context.Authors.Add(item);
            _context.SaveChanges();
        }

        public void Remove(Author item)
        {
            if (_context.Authors.Contains(item))
            {
                _context.Authors.Remove(item);
                _context.SaveChanges();
            }
            else
            {

            }
        }

        public Author Find(int id)
        {
            return _context.Authors.Find(id);
        }

        public void Edit(Author item)
        {
            throw new NotImplementedException();
        }

         
    }
}
