using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class OrderDAO
    {
        private static OrderDAO instance = null;
        private static readonly object instanceLock = new object();
        private MyStoreContext _context;
        private OrderDAO() 
        {
            _context = new MyStoreContext();
        }
        public static OrderDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDAO();
                    }
                    return instance;
                }
            }
        }
        public IEnumerable<Order> GetMembers()
        {
            return _context.Orders.ToList();
        }
        public void Add(Order entity)
        {
            if (entity == null) throw new ArgumentNullException("Entity is null");
            else
            {
                _context.Orders.Add(entity);
                _context.SaveChanges();
            }
        }
        public void Remove(Order entity)
        {
            if (entity == null) throw new ArgumentNullException("Entity is null");
            else
            {
                var found = _context.Orders.Where(m => m.OrderId == entity.OrderId).FirstOrDefault();
                if (found != null)
                {
                    _context.Orders.Remove(found);
                    _context.SaveChanges();
                }
            }
        }
        public void Update(Order entity)
        {
            if (entity == null) throw new ArgumentNullException("Entity is null");
            else
            {
                var found = _context.Orders.Where(m => m.OrderId == entity.OrderId).FirstOrDefault();
                if (found != null)
                {
                    _context.Entry(found).CurrentValues.SetValues(entity);
                    _context.SaveChanges();
                }
            }
        }

        public IEnumerable<Order> GetStatistics(DateTime orderDate, DateTime shippedDate)
        {
            var statistics = new List<Order>();
            try
            {
                using MyStoreContext store = new MyStoreContext();
                statistics = store.Orders.Where(o => o.OrderDate >= orderDate && o.ShippedDate <= shippedDate).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return statistics;
        }
    }
}
