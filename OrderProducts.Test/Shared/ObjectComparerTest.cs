using Container;
using NUnit.Framework;
using OrderProducts.Model;
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
        ObjectComparer<ProductModel> _productComparer;
        ProductModel _p1;
        ProductModel _p2;
        ProductModel _p3;
        List<ProductModel> _products;

        [SetUp]
        public void SetUp()
        {
            _p1 = new ProductModel("A123", "apple", 123, new DateTime());
            _p2 = new ProductModel("A123", "orange", 123, new DateTime());
            _p3 = new ProductModel("A123", "banana", 123, new DateTime());
            IComparer<ProductModel> codeComparer = new ProductCodeComparer("A");
            IComparer<ProductModel> nameComparer = new ProductNameComparer("D");
            List<IComparer<ProductModel>> comparers = new List<IComparer<ProductModel>>();
            _products = new List<ProductModel>();
            _products.Add(_p1);
            _products.Add(_p2);
            _products.Add(_p3);
            comparers.Add(codeComparer);
            comparers.Add(nameComparer);

            _productComparer = new ObjectComparer<ProductModel>(comparers);
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
