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
    public class AuthorService : IService
    {
        AuthorRepository _authorRepository;

        public AuthorService(RepositoryFactory repoFactory)
        {
            _authorRepository = repoFactory.GetAuthorRepository();
        }

        public IEnumerable<Author> All()
        {
            return _authorRepository.All();
        }

        public event EventHandler Updated;

        public void Add(Author author)
        {
            EventArgs ev = new EventArgs();
            _authorRepository.Add(author);
            OnChanged(this, ev);
        }

        public Author Find(Author author)
        {
            int id = author.Id;
            return _authorRepository.Find(id);
        }

        public virtual void OnChanged(Object sender, EventArgs e)
        {
            if (Updated != null)
                Updated(this, e);
        }


      
    }
}

