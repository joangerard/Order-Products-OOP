



using Container;
using OrderProducts.Container;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProducts
{
    class Program
    {
        public MenuComponent CreateMenu(IViewer viewer)
        {
            //Create menu
            MenuComponent booksMenu = new Menu("1", "Books", viewer);
            MenuComponent bookByNameMenuItem = new MenuItem("1", "By Name", viewer);
            MenuComponent bookByAuthorMenuItem = new MenuItem("2", "By Author", viewer);
            MenuComponent bookByIsbnMenuItem = new MenuItem("3", "By Isbn", viewer);
            booksMenu.Add(bookByNameMenuItem);
            booksMenu.Add(bookByAuthorMenuItem);
            booksMenu.Add(bookByIsbnMenuItem);

            MenuComponent productsMenu = new Menu("2", "Products", viewer);
            MenuComponent productByCodeMenuItem = new MenuItem("1", "By Code", viewer);
            MenuComponent productByNameMenuItem = new MenuItem("2", "By Name", viewer);
            MenuComponent productByStockMenuItem = new MenuItem("3", "By Stock", viewer);
            MenuComponent productByExpirationDateMenuItem = new MenuItem("4", "By Expiration Date", viewer);
            productsMenu.Add(productByCodeMenuItem);
            productsMenu.Add(productByNameMenuItem);
            productsMenu.Add(productByStockMenuItem);
            productsMenu.Add(productByExpirationDateMenuItem);

            MenuComponent principalMenu = new Menu("Menu", "Select your option", viewer);
            principalMenu.Add(booksMenu);
            principalMenu.Add(productsMenu);
            return principalMenu;
        }

        static void Main(string[] args)
        {
            StoreFacade storeFacade = new StoreFacade(new ViewerConsole());
            storeFacade.InitProducts();
            storeFacade.InitBooks();
            storeFacade.ShowAllBooks();
            storeFacade.ShowAllProducts();

            ConsoleKeyInfo key = new ConsoleKeyInfo();

            while (key.Key != ConsoleKey.X)
            {
                storeFacade.ShowMenu();
                storeFacade.ReadClientChoice();
                storeFacade.Order();

                storeFacade.ShowAllBooks();
                storeFacade.ShowAllProducts();

                key = Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
