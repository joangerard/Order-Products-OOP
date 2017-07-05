using Container;
using OrderProducts.Model;
using OrderProducts.Repository.Entities;
using OrderProducts.Repository.Interfaces;
using OrderProducts.Repository.Repositories;
using OrderProducts.Services.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProducts.Services
{
    public class ProductServiceFakeData:IProductService
    {
        IPropertyComparerFactory<ProductModel> _productPropertyComparerFactory;
        Interpreter<ProductModel> _interpreterProducts;
        IProductRepository<ProductEntity> _productRepo;
        IMapper<ProductModel, ProductEntity> _productMapper;

        public ProductServiceFakeData()
        {
            _productPropertyComparerFactory = new FactoryProductPropertyComparer();
            _interpreterProducts = new Interpreter<ProductModel>(_productPropertyComparerFactory,"1-A");
            _productRepo = new ProductRepositoryEF();
            _productMapper = new ProductMapper();
        }

        public List<Model.ProductModel> GetAll(string orderOptions)
        {
            List<ProductModel> products = new List<ProductModel>();

            _productRepo.GetAll().ForEach(p => products.Add(_productMapper.Map(p)));

            List<IComparer<ProductModel>> propertyComparers = _interpreterProducts.Translate(orderOptions);
            IComparer<ProductModel> productComparer = new ObjectComparer<ProductModel>(propertyComparers);
            products.Sort(productComparer);

            return products;
        }
    }
}
