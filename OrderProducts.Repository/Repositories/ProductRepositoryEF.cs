using OrderProducts.Repository.Config;
using OrderProducts.Repository.Entities;
using OrderProducts.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProducts.Repository.Repositories
{
    public class ProductRepositoryEF : IProductRepository<ProductEntity>
    {
        public ProductRepositoryEF()
        {
        }

        public int Add(ProductEntity product)
        {
            int i = -1;
            using (var dbContext = new StoreContext())
            {
                dbContext.Products.Add(product);
                dbContext.SaveChanges();
                i = product.ProductId;
            }

            return i;
        }

        public ProductEntity GetByCode(string code)
        {
            ProductEntity productEntity = null;
            using (var dbContext = new StoreContext())
            {
                var product = from p in dbContext.Products
                              where p.Code == code
                              select p;
                productEntity = (ProductEntity)product.FirstOrDefault();
            }
            return productEntity;
        }


        public List<ProductEntity> GetAll()
        {
            List<ProductEntity> products = new List<ProductEntity>();
            using (var dbContext = new StoreContext())
            {
                products=dbContext.Products.ToList();
            }
            return products;
        }
    }
}
