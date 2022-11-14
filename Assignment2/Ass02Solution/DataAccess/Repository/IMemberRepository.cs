using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        IEnumerable<Member> Get();
        void Add(Member entity);
        void Update(Member entity);
        void Remove(Member entity);
    }
}
