



using Container;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            IViewer viewer = new ViewerConsole();
            string optionsParameters, optionsBooksOrProducts;

            Product p1 = new Product("A122", "bread", 4, new DateTime(2017, 12, 12));
            Product p2 = new Product("C123", "pencil", 3, new DateTime(2017, 12, 11));
            Product p3 = new Product("D121", "bread", 4, new DateTime(2017, 12, 10));
            Product p4 = new Product("C123", "pencil", 1, new DateTime(2017, 12, 14));

            Book b1 = new Book("Harry Potter 1", "JK Rowlings", "123456f");
            Book b2 = new Book("Harry Potter 2", "JK Rowlings", "123456j");
            Book b3 = new Book("Harry Potter 3", "JK Rowlings", "123456j");

            ObjectListBase<Book> books = new BookList();
            ObjectListBase<Product> products = new ProductList();

            IFactoryObjectPropertyComparer<Book> factoryBookObjectComparer = new FactoryBookPropertyComparer();
            IFactoryObjectPropertyComparer<Product> factoryProductObjectComparer = new FactoryProductPropertyComparer();
            Translator<Product> translatorProducts = new Translator<Product>(factoryProductObjectComparer, "1-A");
            Translator<Book> translatorBooks = new Translator<Book>(factoryBookObjectComparer, "2-A");

            products.Add(p1);
            products.Add(p2);
            products.Add(p3);
            products.Add(p4);

            books.Add(b1);
            books.Add(b2);
            books.Add(b3);

            while (true)
            {

                Shower.ShowBooksConsole(books);
                Shower.ShowProductsConsole(products);

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
                principalMenu.ShowInformation();

                Console.WriteLine("Books or Products?");
                optionsBooksOrProducts = Console.ReadLine();
                Console.WriteLine("By What?");
                optionsParameters = Console.ReadLine();

                Console.WriteLine();
                Console.WriteLine("RESULT: ");

                if (optionsBooksOrProducts.Equals("1"))
                {
                    List<IObjectOrderDecider<Book>> orders = translatorBooks.Translate(optionsParameters);
                    books.Order(orders);
                    Shower.ShowBooksConsole(books);
                }
                else if (optionsBooksOrProducts.Equals("2"))
                {
                    List<IObjectOrderDecider<Product>> orders = translatorProducts.Translate(optionsParameters);
                    products.Order(orders);
                    Shower.ShowProductsConsole(products);
                }


                Console.ReadKey();
                Console.Clear();
            }

            

            Console.ReadKey();
        }
    }
}
