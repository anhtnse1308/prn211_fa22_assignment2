using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderDetailsRepository : IOrderDetailsRepository
    {
        public void Add(OrderDetail entity) => OrderDetailDAO.Instance.Add(entity);

        public IEnumerable<OrderDetail> Get() => OrderDetailDAO.Instance.GetMembers();

        public void Remove(OrderDetail entity) => OrderDetailDAO.Instance.Remove(entity);

        public void Update(OrderDetail entity) => OrderDetailDAO.Instance.Update(entity);
    }
}
