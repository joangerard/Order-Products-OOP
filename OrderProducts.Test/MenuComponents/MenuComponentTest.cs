using Container;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProducts.Test.MenuComponents
{
    [TestFixture]
    class MenuComponentTest
    {
        Mock<IViewer> _viewer;

        [SetUp]
        public void SetUp()
        {
            _viewer = new Mock<IViewer>();
        }

        [Test]
        public void Add_should_add_a_menu_item_or_a_menu_component()
        {
            MenuComponent container = new Menu("Container", "This contains some child", _viewer.Object);
            MenuComponent booksMenu = new Menu("1", "Books", _viewer.Object);
            MenuComponent bookByNameMenuItem = new MenuItem("1", "By Name", _viewer.Object);
            MenuComponent bookByAuthorMenuItem = new MenuItem("2", "By Author", _viewer.Object);
            MenuComponent bookByIsbnMenuItem = new MenuItem("3", "By Isbn", _viewer.Object);
            booksMenu.Add(bookByNameMenuItem);
            booksMenu.Add(bookByAuthorMenuItem);
            booksMenu.Add(bookByIsbnMenuItem);
            container.Add(booksMenu);
            Assert.AreEqual(container.GetChild(0), booksMenu);
            Assert.AreEqual(booksMenu.GetChild(0), bookByNameMenuItem);
            Assert.AreEqual(booksMenu.GetChild(1), bookByAuthorMenuItem);
            Assert.AreEqual(booksMenu.GetChild(2), bookByIsbnMenuItem);
        }
    }
}
