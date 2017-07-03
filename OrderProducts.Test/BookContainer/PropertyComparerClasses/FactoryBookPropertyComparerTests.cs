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
            factory.SetOption("1");
            Assert.AreEqual(factory.Create().GetType(), typeof(BookNamePropertyComparer));
        }
    }
}
