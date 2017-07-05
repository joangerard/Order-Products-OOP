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
    class ProductExpirationDateComparerTest
    {
        [Test]
        public void Compare_by_expirationDate_should_return_zero_if_they_have_same_expirationDate()
        {
            Product p1 = new Product("123", "we", 123, new DateTime(2017,10,1));
            Product p2 = new Product("123", "we", 123, new DateTime(2017,10,1));
            IComparer<Product> expirationDateComparer = new ProductExpirationDateComparer("A");
            int result = expirationDateComparer.Compare(p1, p2);
            Assert.AreEqual(result, 0);
        }

        [Test]
        public void Compare_by_expirationDate_descending_should_return_one_if_the_the_first_expirationDate_follows_the_second()
        {
            Product p1 = new Product("A123", "we", 123, new DateTime(2017,10,1));
            Product p2 = new Product("B123", "we", 123, new DateTime(2017,10,2));
            IComparer<Product> expirationDateComparer = new ProductExpirationDateComparer("D");
            int result = expirationDateComparer.Compare(p1, p2);
            Assert.AreEqual(result, 1);
        }

        [Test]
        public void Compare_by_expirationDate_descending_should_return_minus_one_if_the_the_first_expirationDate_precedes_the_second()
        {
            Product p1 = new Product("B123", "we", 123, new DateTime(2017,10,2));
            Product p2 = new Product("A123", "we", 123, new DateTime(2017,10,1));
            IComparer<Product> expirationDateComparer = new ProductExpirationDateComparer("D");
            int result = expirationDateComparer.Compare(p1, p2);
            Assert.AreEqual(result, -1);
        }

        [Test]
        public void Compare_by_expirationDate_ascending_should_return_one_if_the_the_second_expirationDate_follows_the_first()
        {
            Product p1 = new Product("B123", "we", 123, new DateTime(2017,10,2));
            Product p2 = new Product("A123", "we", 123, new DateTime(2017,10,1));
            IComparer<Product> expirationDateComparer = new ProductExpirationDateComparer("A");
            int result = expirationDateComparer.Compare(p1, p2);
            Assert.AreEqual(result, 1);
        }

        [Test]
        public void Compare_by_expirationDate_ascending_should_return_minus_one_if_the_the_second_expirationDate_precedes_the_first()
        {
            Product p1 = new Product("A123", "we", 123, new DateTime(2017,10,1));
            Product p2 = new Product("B123", "we", 123, new DateTime(2017,10,2));
            IComparer<Product> expirationDateComparer = new ProductExpirationDateComparer("A");
            int result = expirationDateComparer.Compare(p1, p2);
            Assert.AreEqual(result, -1);
        }
    }
}
