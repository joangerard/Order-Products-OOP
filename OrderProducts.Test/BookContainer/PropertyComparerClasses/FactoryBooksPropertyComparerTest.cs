using Container;
using NUnit.Framework;
using OrderProducts.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProducts.Test.BookContainer.PropertyComparerClasses
{
    [TestFixture]
    class FactoryBooksPropertyComparerTest
    {
        [Test]
        [TestCase("A", "1", typeof(BookNamePropertyComparer))]
        [TestCase("A", "2", typeof(BookAuthorPropertyComparer))]
        [TestCase("A", "3", typeof(BookIsbnPropertyComparer))]

        public void Create_should_return_instance_of_the_correct_class(string optionOrder,string optionType,Type result)
        {
            IPropertyComparerFactory<BookModel> factoryBookPropertyFactory = new FactoryBookPropertyComparer();
            IComparer<BookModel> res = factoryBookPropertyFactory.Create(optionOrder, optionType);
            Assert.AreEqual(result, res.GetType());
        }
    }
}
