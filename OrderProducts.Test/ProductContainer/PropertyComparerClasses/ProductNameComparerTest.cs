using Container;
using NUnit.Framework;
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
            Product p1 = new Product("123", "apple", 123, new DateTime());
            Product p2 = new Product("123", "apple", 123, new DateTime());
            IComparer<Product> nameComparer = new ProductNameComparer("A");
            int result = nameComparer.Compare(p1, p2);
            Assert.AreEqual(result, 0);
        }

        [Test]
        public void Compare_by_name_descending_should_return_one_if_the_the_first_name_follows_the_second()
        {
            Product p1 = new Product("A123", "apple", 123, new DateTime());
            Product p2 = new Product("B123", "orange", 123, new DateTime());
            IComparer<Product> nameComparer = new ProductNameComparer("D");
            int result = nameComparer.Compare(p1, p2);
            Assert.AreEqual(result, 1);
        }

        [Test]
        public void Compare_by_name_descending_should_return_minus_one_if_the_the_first_name_precedes_the_second()
        {
            Product p1 = new Product("B123", "orange", 123, new DateTime());
            Product p2 = new Product("A123", "apple", 123, new DateTime());
            IComparer<Product> nameComparer = new ProductNameComparer("D");
            int result = nameComparer.Compare(p1, p2);
            Assert.AreEqual(result, -1);
        }

        [Test]
        public void Compare_by_name_ascending_should_return_one_if_the_the_second_name_follows_the_first()
        {
            Product p1 = new Product("B123", "orange", 123, new DateTime());
            Product p2 = new Product("A123", "apple", 123, new DateTime());
            IComparer<Product> nameComparer = new ProductNameComparer("A");
            int result = nameComparer.Compare(p1, p2);
            Assert.AreEqual(result, 1);
        }

        [Test]
        public void Compare_by_name_ascending_should_return_minus_one_if_the_the_second_name_precedes_the_first()
        {
            Product p1 = new Product("A123", "apple", 123, new DateTime());
            Product p2 = new Product("B123", "orange", 123, new DateTime());
            IComparer<Product> nameComparer = new ProductNameComparer("A");
            int result = nameComparer.Compare(p1, p2);
            Assert.AreEqual(result, -1);
        }
    }
}
