using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class OrderDetailDAO
    {
        private static OrderDetailDAO instance = null;
        private static readonly object instanceLock = new object();
        private MyStoreContext _context;
        private OrderDetailDAO() 
        { 
            _context = new MyStoreContext();
        }
        public static OrderDetailDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDetailDAO();
                    }
                    return instance;
                }
            }
        }
        public IEnumerable<OrderDetail> GetMembers()
        {
            return _context.OrderDetails.ToList();
        }
        public void Add(OrderDetail entity)
        {
            if (entity == null) throw new ArgumentNullException("Entity is null");
            else
            {
                _context.OrderDetails.Add(entity);
                _context.SaveChanges();
            }
        }
        public void Remove(OrderDetail entity)
        {
            if (entity == null) throw new ArgumentNullException("Entity is null");
            else
            {
                var found = _context.OrderDetails.Where(m => (m.ProductId == entity.ProductId) && (m.OrderId == entity.OrderId)).FirstOrDefault();
                if (found != null)
                {
                    _context.OrderDetails.Remove(found);
                    _context.SaveChanges();
                }
            }
        }
        public void Update(OrderDetail entity)
        {
            if (entity == null) throw new ArgumentNullException("Entity is null");
            else
            {
                var found = _context.OrderDetails.Where(m => (m.ProductId == entity.ProductId) && (m.OrderId == entity.OrderId)).FirstOrDefault();
                if (found != null)
                {
                    _context.Entry(found).CurrentValues.SetValues(entity);
                    _context.SaveChanges();
                }
            }
        }
    }
}
