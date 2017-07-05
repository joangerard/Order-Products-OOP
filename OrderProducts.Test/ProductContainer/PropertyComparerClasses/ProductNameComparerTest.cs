using Container;
using NUnit.Framework;
using OrderProducts.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProducts.Test.ProductContainer.PropertyComparerClasses
{
    [TestFixture]
    class ProductNameComparerTest
    {
        [Test]
        public void Compare_by_name_should_return_zero_if_they_have_same_name()
        {
            ProductModel p1 = new ProductModel("123", "apple", 123, new DateTime());
            ProductModel p2 = new ProductModel("123", "apple", 123, new DateTime());
            IComparer<ProductModel> nameComparer = new ProductNameComparer("A");
            int result = nameComparer.Compare(p1, p2);
            Assert.AreEqual(result, 0);
        }

        [Test]
        public void Compare_by_name_descending_should_return_one_if_the_the_first_name_follows_the_second()
        {
            ProductModel p1 = new ProductModel("A123", "apple", 123, new DateTime());
            ProductModel p2 = new ProductModel("B123", "orange", 124, new DateTime());
            IComparer<ProductModel> nameComparer = new ProductNameComparer("D");
            int result = nameComparer.Compare(p1, p2);
            Assert.AreEqual(result, 1);
        }

        [Test]
        public void Compare_by_name_descending_should_return_minus_one_if_the_the_first_name_precedes_the_second()
        {
            ProductModel p1 = new ProductModel("B123", "orange", 124, new DateTime());
            ProductModel p2 = new ProductModel("A123", "apple", 123, new DateTime());
            IComparer<ProductModel> nameComparer = new ProductNameComparer("D");
            int result = nameComparer.Compare(p1, p2);
            Assert.AreEqual(result, -1);
        }

        [Test]
        public void Compare_by_name_ascending_should_return_one_if_the_the_second_name_follows_the_first()
        {
            ProductModel p1 = new ProductModel("B123", "orange", 124, new DateTime());
            ProductModel p2 = new ProductModel("A123", "apple", 123, new DateTime());
            IComparer<ProductModel> nameComparer = new ProductNameComparer("A");
            int result = nameComparer.Compare(p1, p2);
            Assert.AreEqual(result, 1);
        }

        [Test]
        public void Compare_by_name_ascending_should_return_minus_one_if_the_the_second_name_precedes_the_first()
        {
            ProductModel p1 = new ProductModel("A123", "apple", 123, new DateTime());
            ProductModel p2 = new ProductModel("B123", "orange", 124, new DateTime());
            IComparer<ProductModel> nameComparer = new ProductNameComparer("A");
            int result = nameComparer.Compare(p1, p2);
            Assert.AreEqual(result, -1);
        }
    }
}
