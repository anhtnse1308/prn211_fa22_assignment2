using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderRepository : IOrderRepository
    {
        public void Add(Order entity) => OrderDAO.Instance.Add(entity);

        public IEnumerable<Order> Get() => OrderDAO.Instance.Get();

        public void Remove(Order entity) => OrderDAO.Instance.Remove(entity);

        public void Update(Order entity) => OrderDAO.Instance.Update(entity);

        public IEnumerable<Order> GetStatistics(DateTime orderDate, DateTime shippedDate)
      => OrderDAO.Instance.GetStatistics(orderDate, shippedDate);
    }
}
