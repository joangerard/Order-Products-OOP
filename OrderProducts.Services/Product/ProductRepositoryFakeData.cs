using Container;
using OrderProducts.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProducts.Services
{
    public class ProductRepositoryFakeData:IProductRepository
    {
        IPropertyComparerFactory<Product> _productPropertyComparerFactory;
        Interpreter<Product> _interpreterProducts;

        public ProductRepositoryFakeData()
        {
            _productPropertyComparerFactory = new FactoryProductPropertyComparer();
            _interpreterProducts = new Interpreter<Product>(_productPropertyComparerFactory,"1-A");
        }

        public List<Model.Product> GetAll(string orderOptions)
        {
            List<Product> products = new List<Product>();

            Product p1 = new Product("A122", "bread", 4, new DateTime(2017, 12, 12));
            Product p2 = new Product("C123", "pencil", 3, new DateTime(2017, 12, 11));
            Product p3 = new Product("D121", "bread", 4, new DateTime(2017, 12, 10));
            Product p4 = new Product("C123", "pencil", 1, new DateTime(2017, 12, 14));

            products.Add(p1);
            products.Add(p2);
            products.Add(p3);
            products.Add(p4);

            List<IComparer<Product>> propertyComparers = _interpreterProducts.Translate(orderOptions);
            IComparer<Product> productComparer = new ObjectComparer<Product>(propertyComparers);
            products.Sort(productComparer);

            return products;
        }
    }
}
