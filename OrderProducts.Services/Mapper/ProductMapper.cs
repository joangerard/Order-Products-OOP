using OrderProducts.Model;
using OrderProducts.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProducts.Services.Mapper
{
    public class ProductMapper : IMapper<ProductModel, ProductEntity>
    {
        public ProductMapper()
        {

        }

        public ProductModel Map(ProductEntity productEntity)
        {
            return new ProductModel(
                productEntity.Code,
                productEntity.Name,
                productEntity.Stock,
                productEntity.ExpirationDate);
        }

        public ProductEntity Map(ProductModel productModel)
        {
            return new ProductEntity
            {
                Code = productModel.Code,
                Name = productModel.Name,
                Stock = productModel.Stock,
                ExpirationDate = productModel.ExpirationDate
            };
        }
    }
}
