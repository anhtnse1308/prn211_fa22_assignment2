using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class MemberDAO
    {
        private static MemberDAO instance = null;
        private static readonly object instanceLock = new object();
        private MyStoreContext _context;
        private MemberDAO()
        {
            _context = new MyStoreContext();
        }
        public static MemberDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new MemberDAO();
                    }
                    return instance;
                }
            }
        }
        public IEnumerable<Member> GetMembers()
        {
            return _context.Members.ToList();
        }
        public void Add(Member entity)
        {
            if (entity == null) throw new ArgumentNullException("Entity is null");
            else
            {
                _context.Members.Add(entity);
                _context.SaveChanges();
            }
        }
        public void Remove(Member entity)
        {
            if (entity == null) throw new ArgumentNullException("Entity is null");
            else
            {
                var found = _context.Members.Where(m => m.MemberId == entity.MemberId).FirstOrDefault();
                if (found != null)
                {
                    _context.Members.Remove(found);
                    _context.SaveChanges();
                }
            }
        }
        public void Update(Member entity)
        {
            if (entity == null) throw new ArgumentNullException("Entity is null");
            else
            {
                var found = _context.Members.Where(m => m.MemberId == entity.MemberId).FirstOrDefault();
                if (found != null)
                {
                    _context.Entry(found).CurrentValues.SetValues(entity);
                    _context.SaveChanges();
                }
            }
        }
    }
}
