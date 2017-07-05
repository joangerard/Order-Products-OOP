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
    class BookAuthorPropertyComparerTest
    {
        [Test]
        public void Compare_by_author_should_return_zero_if_they_have_same_author()
        {
            Book b1 = new Book("Harry Potter 1","JK Rowlings","ASDF445FD");
            Book b2 = new Book("Le tour au mond en 80 jours", "Verne J.", "BSD1FD12S");
            IComparer<Book> authorComparer = new BookAuthorPropertyComparer("A");
            int result = authorComparer.Compare(b1, b1);
            Assert.AreEqual(result, 0);
        }

        [Test]
        public void Compare_by_author_descending_should_return_one_if_the_the_first_author_follows_the_second()
        {
            Book b1 = new Book("Harry Potter 1", "JK Rowlings", "ASDF445FD");
            Book b2 = new Book("Le tour au mond en 80 jours", "Verne J.", "BSD1FD12S");
            IComparer<Book> authorComparer = new BookAuthorPropertyComparer("D");
            int result = authorComparer.Compare(b1, b2);
            Assert.AreEqual(result, 1);
        }

        [Test]
        public void Compare_by_author_descending_should_return_minus_one_if_the_the_first_author_precedes_the_second()
        {
            Book b1 = new Book("Le tour au mond en 80 jours", "Verne J.", "BSD1FD12S");
            Book b2 = new Book("Harry Potter 1", "JK Rowlings", "ASDF445FD"); 
            IComparer<Book> authorComparer = new BookAuthorPropertyComparer("D");
            int result = authorComparer.Compare(b1, b2);
            Assert.AreEqual(result, -1);
        }

        [Test]
        public void Compare_by_author_ascending_should_return_one_if_the_the_second_author_follows_the_first()
        {
            Book b1 = new Book("Le tour au mond en 80 jours", "Verne J.", "BSD1FD12S");
            Book b2 = new Book("Harry Potter 1", "JK Rowlings", "ASDF445FD");
            IComparer<Book> authorComparer = new BookAuthorPropertyComparer("A");
            int result = authorComparer.Compare(b1, b2);
            Assert.AreEqual(result, 1);
        }

        [Test]
        public void Compare_by_author_ascending_should_return_minus_one_if_the_the_second_author_precedes_the_first()
        {
            Book b1 = new Book("Harry Potter 1", "JK Rowlings", "ASDF445FD");
            Book b2 = new Book("Le tour au mond en 80 jours", "Verne J.", "BSD1FD12S");
            IComparer<Book> authorComparer = new BookAuthorPropertyComparer("A");
            int result = authorComparer.Compare(b1, b2);
            Assert.AreEqual(result, -1);
        }
    }
}
