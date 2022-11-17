using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IOrderRepository
    {
        IEnumerable<Order> Get();
        void Add(Order entity);
        void Update(Order entity);
        void Remove(Order entity);
        IEnumerable<Order> GetStatistics(DateTime orderDate, DateTime shippedDate);
    }
}
