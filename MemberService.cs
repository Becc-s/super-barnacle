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
    public class MemberService: IService 
    {
        MemberRepository _MemberRepository;

        public MemberService(RepositoryFactory repoFactory)
        {
            _MemberRepository = repoFactory.GetMemberRepository();
        }

        public IEnumerable<Member> All()
        {
            return _MemberRepository.All();
        }

        public void Add(Member member)
        {
            EventArgs ev = new EventArgs();
            _MemberRepository.Add(member);
            OnChanged(this, ev);
        }

        public event EventHandler Updated;

        public virtual void OnChanged(Object sender, EventArgs e)
        {
            if (Updated != null)
                Updated(this, e);
        }

    }
}
