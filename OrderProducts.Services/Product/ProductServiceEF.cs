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

namespace OrderProducts.Services.Product
{
    public class ProductServiceEF:IProductService
    {
        IProductRepository<ProductEntity> _productRepo;
        IPropertyComparerFactory<ProductModel> _productPropertyComparerFactory;
        IMapper<ProductModel,ProductEntity> _mapper;
        IComparer<ProductModel> _productComparer;

        public ProductServiceEF()
        {
            _productRepo = new ProductRepositoryEF();
            _productPropertyComparerFactory = new FactoryProductPropertyComparer();
            _mapper = new ProductMapper();
        }

        public List<Model.ProductModel> GetAll(string orderOptions)
        {
            List<ProductEntity> productEntities = _productRepo.GetAll();
            List<ProductModel> productModels = new List<ProductModel>();
            
            foreach (var p in productEntities)
            {
                productModels.Add(_mapper.Map(p));
            }

            _productComparer = new ObjectComparer<ProductModel>(orderOptions, _productPropertyComparerFactory);
            productModels.Sort(_productComparer);

            return productModels;
        }

        public int Create(Model.ProductModel product)
        {
            ProductEntity productEntity = _mapper.Map(product);
            return _productRepo.Add(productEntity);
        }

        public ProductModel GetByCode(string code)
        {
            ProductEntity productEntity = _productRepo.GetByCode(code);
            ProductModel productModel = null;
            if(productEntity!=null)
               productModel = _mapper.Map(productEntity);
            return productModel;
        }
    }
}
