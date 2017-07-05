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
            ProductModel p1 = new ProductModel("123", "we", 123, new DateTime(2017,10,1));
            ProductModel p2 = new ProductModel("123", "we", 123, new DateTime(2017,10,1));
            IComparer<ProductModel> expirationDateComparer = new ProductExpirationDateComparer("A");
            int result = expirationDateComparer.Compare(p1, p2);
            Assert.AreEqual(result, 0);
        }

        [Test]
        public void Compare_by_expirationDate_descending_should_return_one_if_the_the_first_expirationDate_follows_the_second()
        {
            ProductModel p1 = new ProductModel("A123", "we", 123, new DateTime(2017,10,1));
            ProductModel p2 = new ProductModel("B123", "we", 123, new DateTime(2017,10,2));
            IComparer<ProductModel> expirationDateComparer = new ProductExpirationDateComparer("D");
            int result = expirationDateComparer.Compare(p1, p2);
            Assert.AreEqual(result, 1);
        }

        [Test]
        public void Compare_by_expirationDate_descending_should_return_minus_one_if_the_the_first_expirationDate_precedes_the_second()
        {
            ProductModel p1 = new ProductModel("B123", "we", 123, new DateTime(2017,10,2));
            ProductModel p2 = new ProductModel("A123", "we", 123, new DateTime(2017,10,1));
            IComparer<ProductModel> expirationDateComparer = new ProductExpirationDateComparer("D");
            int result = expirationDateComparer.Compare(p1, p2);
            Assert.AreEqual(result, -1);
        }

        [Test]
        public void Compare_by_expirationDate_ascending_should_return_one_if_the_the_second_expirationDate_follows_the_first()
        {
            ProductModel p1 = new ProductModel("B123", "we", 123, new DateTime(2017,10,2));
            ProductModel p2 = new ProductModel("A123", "we", 123, new DateTime(2017,10,1));
            IComparer<ProductModel> expirationDateComparer = new ProductExpirationDateComparer("A");
            int result = expirationDateComparer.Compare(p1, p2);
            Assert.AreEqual(result, 1);
        }

        [Test]
        public void Compare_by_expirationDate_ascending_should_return_minus_one_if_the_the_second_expirationDate_precedes_the_first()
        {
            ProductModel p1 = new ProductModel("A123", "we", 123, new DateTime(2017,10,1));
            ProductModel p2 = new ProductModel("B123", "we", 123, new DateTime(2017,10,2));
            IComparer<ProductModel> expirationDateComparer = new ProductExpirationDateComparer("A");
            int result = expirationDateComparer.Compare(p1, p2);
            Assert.AreEqual(result, -1);
        }
    }
}
