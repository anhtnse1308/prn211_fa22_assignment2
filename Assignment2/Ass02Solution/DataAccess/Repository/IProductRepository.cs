using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DataAccess.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> Get();
        void Add(Product entity);
        void Update(Product entity);
        void Remove(Product entity);
    }
}
