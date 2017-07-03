using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderProducts;
using Container;

namespace OrderProducts.Container.Test.BookContainer.PropertyComparerClasses
{
    [TestFixture]
    public class FactoryBookPropertyComparerTests
    {
        [Test]
        public void CreateOneShouldReturnBookNamePropertyComparer()
        {
            FactoryBookPropertyComparer factory = new FactoryBookPropertyComparer();
            Assert.AreEqual(factory.Create("1").GetType(), typeof(BookNamePropertyComparer));
        }
    }
}
