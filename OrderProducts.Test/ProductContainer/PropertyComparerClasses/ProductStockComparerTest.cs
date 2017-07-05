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
    class ProductStockComparerTest
    {
        [Test]
        public void Compare_by_stock_should_return_zero_if_they_have_same_stock()
        {
            Product p1 = new Product("123", "apple", 123, new DateTime());
            Product p2 = new Product("123", "apple", 123, new DateTime());
            IComparer<Product> stockComparer = new ProductStockComparer("A");
            int result = stockComparer.Compare(p1, p2);
            Assert.AreEqual(result, 0);
        }

        [Test]
        public void Compare_by_stock_descending_should_return_one_if_the_the_first_stock_follows_the_second()
        {
            Product p1 = new Product("A123", "apple", 123, new DateTime());
            Product p2 = new Product("B123", "apple", 124, new DateTime());
            IComparer<Product> stockComparer = new ProductStockComparer("D");
            int result = stockComparer.Compare(p1, p2);
            Assert.AreEqual(result, 1);
        }

        [Test]
        public void Compare_by_stock_descending_should_return_minus_one_if_the_the_first_stock_precedes_the_second()
        {
            Product p1 = new Product("B123", "apple", 124, new DateTime());
            Product p2 = new Product("A123", "apple", 123, new DateTime());
            IComparer<Product> stockComparer = new ProductStockComparer("D");
            int result = stockComparer.Compare(p1, p2);
            Assert.AreEqual(result, -1);
        }

        [Test]
        public void Compare_by_stock_ascending_should_return_one_if_the_the_second_stock_follows_the_first()
        {
            Product p1 = new Product("B123", "apple", 124, new DateTime());
            Product p2 = new Product("A123", "apple", 123, new DateTime());
            IComparer<Product> stockComparer = new ProductStockComparer("A");
            int result = stockComparer.Compare(p1, p2);
            Assert.AreEqual(result, 1);
        }

        [Test]
        public void Compare_by_stock_ascending_should_return_minus_one_if_the_the_second_stock_precedes_the_first()
        {
            Product p1 = new Product("A123", "apple", 123, new DateTime());
            Product p2 = new Product("B123", "orange", 124, new DateTime());
            IComparer<Product> stockComparer = new ProductStockComparer("A");
            int result = stockComparer.Compare(p1, p2);
            Assert.AreEqual(result, -1);
        }
    }
}
