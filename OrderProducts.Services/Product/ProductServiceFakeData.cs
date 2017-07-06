using Container;
using OrderProducts.Model;
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
        List<ProductModel> _products;

        public ProductServiceFakeData()
        {
            _productPropertyComparerFactory = new FactoryProductPropertyComparer();
            _products = new List<ProductModel>();
            InitProducts();
        }

        private void InitProducts()
        {
            ProductModel p1 = new ProductModel("A122", "bread", 4, new DateTime(2017, 12, 12));
            ProductModel p2 = new ProductModel("C123", "pencil", 3, new DateTime(2017, 12, 11));
            ProductModel p3 = new ProductModel("D121", "bread", 4, new DateTime(2017, 12, 10));
            ProductModel p4 = new ProductModel("C123", "pencil", 1, new DateTime(2017, 12, 14));

            _products.Add(p1);
            _products.Add(p2);
            _products.Add(p3);
            _products.Add(p4);
        }

        public List<Model.ProductModel> GetAll(string orderOptions)
        {
            IComparer<ProductModel> productComparer = new ObjectComparer<ProductModel>(orderOptions, _productPropertyComparerFactory);
            _products.Sort(productComparer);
            return _products;
        }


        public int Create(ProductModel product)
        {
            _products.Add(product);
            return _products.Count();
        }


        public ProductModel GetByCode(string code)
        {
            var product = from p in _products
                          where p.Code == code
                          select p;
            return (ProductModel)product;
        }
    }
}
