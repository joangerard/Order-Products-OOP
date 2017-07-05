using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Container;
using OrderProducts.Model;

namespace OrderProducts.Test.ProductContainer.PropertyComparerClasses
{
    [TestFixture]
    class ProductCodeComparerTest
    {
        [Test]
        public void Compare_by_code_should_return_zero_if_they_have_same_code()
        {
            ProductModel p1 = new ProductModel("123","we",123,new DateTime());
            ProductModel p2 = new ProductModel("123", "we", 123, new DateTime());
            IComparer<ProductModel> codeComparer = new ProductCodeComparer("A");
            int result = codeComparer.Compare(p1, p2);
            Assert.AreEqual(result, 0);
        }

        [Test]
        public void Compare_by_code_descending_should_return_one_if_the_the_first_code_follows_the_second()
        {
            ProductModel p1 = new ProductModel("A123", "we", 123, new DateTime());
            ProductModel p2 = new ProductModel("B123", "we", 123, new DateTime());
            IComparer<ProductModel> codeComparer = new ProductCodeComparer("D");
            int result = codeComparer.Compare(p1, p2);
            Assert.AreEqual(result, 1);
        }

        [Test]
        public void Compare_by_code_descending_should_return_minus_one_if_the_the_first_code_precedes_the_second()
        {
            ProductModel p1 = new ProductModel("B123", "we", 123, new DateTime());
            ProductModel p2 = new ProductModel("A123", "we", 123, new DateTime());
            IComparer<ProductModel> codeComparer = new ProductCodeComparer("D");
            int result = codeComparer.Compare(p1, p2);
            Assert.AreEqual(result, -1);
        }

        [Test]
        public void Compare_by_code_ascending_should_return_one_if_the_the_second_code_follows_the_first()
        {
            ProductModel p1 = new ProductModel("B123", "we", 123, new DateTime());
            ProductModel p2 = new ProductModel("A123", "we", 123, new DateTime());
            IComparer<ProductModel> codeComparer = new ProductCodeComparer("A");
            int result = codeComparer.Compare(p1, p2);
            Assert.AreEqual(result, 1);
        }

        [Test]
        public void Compare_by_code_ascending_should_return_minus_one_if_the_the_second_code_precedes_the_first()
        {
            ProductModel p1 = new ProductModel("A123", "we", 123, new DateTime());
            ProductModel p2 = new ProductModel("B123", "we", 123, new DateTime());
            IComparer<ProductModel> codeComparer = new ProductCodeComparer("A");
            int result = codeComparer.Compare(p1, p2);
            Assert.AreEqual(result, -1);
        }
    }
}
