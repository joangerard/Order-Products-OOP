using OrderProducts.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProducts.Repository.Interfaces
{
    public interface IProductRepository<T>
    {
        int Add(T product);
        List<ProductEntity> GetAll();
    }
}
