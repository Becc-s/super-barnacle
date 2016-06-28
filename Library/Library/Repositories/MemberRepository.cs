//Rebecka Åkhagen Holm
//V. 1.0
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Models;


namespace Library.Repositories
{
    public class MemberRepository : IRepository<Member, int>
    {
        LibraryContext _context;

        public MemberRepository(LibraryContext ctx)
        {
            _context = ctx;
        }

        public void Add(Member item)
        {
            _context.Members.Add(item);
            _context.SaveChanges();
        }

        public void Remove(Member item)
        {
           _context.Members.Remove(item);
           _context.SaveChanges();
          
        }

        public Member Find(int id)
        {
            return _context.Members.Find(id);
        }

        public void Edit(Member item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Member> All()
        {
            return _context.Members.ToList();
        }
    }
}
