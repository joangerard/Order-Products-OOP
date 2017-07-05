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
    class BookNamePropertyComparerTest
    {
        [Test]
        public void Compare_by_name_should_return_zero_if_they_have_same_name()
        {
            Book b1 = new Book("Harry Potter 1", "JK Rowlings", "ASDF445FD");
            Book b2 = new Book("Le tour au mond en 80 jours", "Verne J.", "BSD1FD12S");
            IComparer<Book> nameComparer = new BookNamePropertyComparer("A");
            int result = nameComparer.Compare(b1, b1);
            Assert.AreEqual(result, 0);
        }

        [Test]
        public void Compare_by_name_descending_should_return_one_if_the_the_first_name_follows_the_second()
        {
            Book b1 = new Book("Harry Potter 1", "JK Rowlings", "ASDF445FD");
            Book b2 = new Book("Le tour au mond en 80 jours", "Verne J.", "BSD1FD12S");
            IComparer<Book> nameComparer = new BookNamePropertyComparer("D");
            int result = nameComparer.Compare(b1, b2);
            Assert.AreEqual(result, 1);
        }

        [Test]
        public void Compare_by_name_descending_should_return_minus_one_if_the_the_first_name_precedes_the_second()
        {
            Book b1 = new Book("Le tour au mond en 80 jours", "Verne J.", "BSD1FD12S");
            Book b2 = new Book("Harry Potter 1", "JK Rowlings", "ASDF445FD");
            IComparer<Book> nameComparer = new BookNamePropertyComparer("D");
            int result = nameComparer.Compare(b1, b2);
            Assert.AreEqual(result, -1);
        }

        [Test]
        public void Compare_by_name_ascending_should_return_one_if_the_the_second_name_follows_the_first()
        {
            Book b1 = new Book("Le tour au mond en 80 jours", "Verne J.", "BSD1FD12S");
            Book b2 = new Book("Harry Potter 1", "JK Rowlings", "ASDF445FD");
            IComparer<Book> nameComparer = new BookNamePropertyComparer("A");
            int result = nameComparer.Compare(b1, b2);
            Assert.AreEqual(result, 1);
        }

        [Test]
        public void Compare_by_name_ascending_should_return_minus_one_if_the_the_second_name_precedes_the_first()
        {
            Book b1 = new Book("Harry Potter 1", "JK Rowlings", "ASDF445FD");
            Book b2 = new Book("Le tour au mond en 80 jours", "Verne J.", "BSD1FD12S");
            IComparer<Book> nameComparer = new BookAuthorPropertyComparer("A");
            int result = nameComparer.Compare(b1, b2);
            Assert.AreEqual(result, -1);
        }
    }
}
