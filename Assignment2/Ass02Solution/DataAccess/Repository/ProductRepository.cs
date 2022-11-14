using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class ProductRepository : IProductRepository
    {
        public void Add(Product entity) => ProductDAO.Instance.Add(entity);

        public IEnumerable<Product> Get() => ProductDAO.Instance.GetMembers();

        public void Remove(Product entity) => ProductDAO.Instance.Remove(entity);

        public void Update(Product entity) => ProductDAO.Instance.Update(entity);
    }
}
