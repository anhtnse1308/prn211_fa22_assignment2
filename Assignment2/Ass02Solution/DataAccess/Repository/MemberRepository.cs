using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        public void Add(Member entity) => MemberDAO.Instance.Add(entity);

        public IEnumerable<Member> Get() => MemberDAO.Instance.GetMembers();

        public void Remove(Member entity) => MemberDAO.Instance.Remove(entity);

        public void Update(Member entity) => MemberDAO.Instance.Update(entity);
    }
}
