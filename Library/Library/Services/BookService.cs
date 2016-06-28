//Rebecka Åkhagen Holm
//V. 1.0
using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services {
    public class BookService : IService
    {
        BookRepository _bookRepository;



        public BookService(RepositoryFactory repoFactory)
        {
            _bookRepository = repoFactory.GetBookRepository();
        }

        public IEnumerable<Book> All()
        {
            return _bookRepository.All();
        }

        public void Add(Book bok)
        {
            EventArgs ev = new EventArgs();
            _bookRepository.Add(bok);
            OnChanged(this, ev);
        }

        public void Remove(Book bok)
        {
            EventArgs ev = new EventArgs();
            _bookRepository.Remove(bok);
            OnChanged(this, ev);
        }

        public event EventHandler Updated;

        public IEnumerable<Book> GetBooksByAuthor(Author author)
        {
            var getbooks = from book in _bookRepository.All()
                           where book.Author == author
                           select book;
            return getbooks;
            
        }

        public virtual void OnChanged(Object sender, EventArgs e)
        {
            if (Updated != null)
                Updated(this, e);
        }
    }
}
