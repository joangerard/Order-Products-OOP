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
    class FactoryProductPropertyComparerTest
    {
        [Test]
        [TestCase("A", "1", typeof(ProductCodeComparer))]
        [TestCase("A", "2", typeof(ProductNameComparer))]
        [TestCase("A", "3", typeof(ProductStockComparer))]
        [TestCase("A", "4", typeof(ProductExpirationDateComparer))]
        public void Create_should_return_instance_of_the_correct_class(string optionOrder, string optionType, Type result)
        {
            IPropertyComparerFactory<Product> factoryProductPropertyFactory = new FactoryProductPropertyComparer();
            IComparer<Product> res = factoryProductPropertyFactory.Create(optionOrder, optionType);
            Assert.AreEqual(result, res.GetType());
        }
    }
}