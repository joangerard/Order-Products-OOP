using Container;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProducts.Test.Shared
{
    [TestFixture]
    class ObjectComparerTest
    {
        ObjectComparer<Product> _productComparer;
        Product _p1;
        Product _p2;
        Product _p3;
        List<Product> _products;

        [SetUp]
        public void SetUp()
        {
            _p1 = new Product("A123", "apple", 123, new DateTime());
            _p2 = new Product("A123", "orange", 123, new DateTime());
            _p3 = new Product("A123", "banana", 123, new DateTime());
            IComparer<Product> codeComparer = new ProductCodeComparer("A");
            IComparer<Product> nameComparer = new ProductNameComparer("D");
            List<IComparer<Product>> comparers = new List<IComparer<Product>>();
            _products = new List<Product>();
            _products.Add(_p1);
            _products.Add(_p2);
            _products.Add(_p3);
            comparers.Add(codeComparer);
            comparers.Add(nameComparer);

            _productComparer = new ObjectComparer<Product>(comparers);
        }

        [Test]
        public void Comparer_product_by_code_and_name_descending_should_return_zero()
        {
            Assert.AreEqual(_productComparer.Compare(_p1, _p1), 0);
        }

        [Test]
        public void Comparer_product_by_code_and_name_descending_should_return_minus_one()
        {
            Assert.AreEqual(_productComparer.Compare(_p1, _p2), 1);
        }

        [Test]
        public void Comparer_product_by_code_and_name_descending_should_return_one()
        {
            Assert.AreEqual(_productComparer.Compare(_p2,_p1 ), -1);
        }

        [Test]
        public void Sort_by_code_and_name()
        {
            _products.Sort(_productComparer);
            Assert.AreEqual(_products[0].Name, _p2.Name);
            Assert.AreEqual(_products[1].Name, _p3.Name);
            Assert.AreEqual(_products[2].Name, _p1.Name);
        }
    }
}
