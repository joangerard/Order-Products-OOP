using Container;
using OrderProducts.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Container
{
    public class StoreFacade
    {
        IViewer viewer;
        List<ProductModel> products;
        List<BookModel> books;

        IPropertyComparerFactory<BookModel> bookPropertyComparerFactory;
        IPropertyComparerFactory<ProductModel> productPropertyComparerFactory;
        string optionsBooksOrProducts;
        string optionsParameters;

        public StoreFacade(IViewer viewer)
        {
            this.viewer = viewer;
            this.products = new List<ProductModel>();
            this.books = new List<BookModel>();

            this.bookPropertyComparerFactory = new FactoryBookPropertyComparer();
            this.productPropertyComparerFactory = new FactoryProductPropertyComparer();

        }

        public void ShowAllProducts()
        {
            viewer.ShowProducts(products);
        }

        public void ShowAllBooks()
        {
            viewer.ShowBooks(books);
        }

        public void InitProducts()
        {
            ProductModel p1 = new ProductModel("A122", "bread", 4, new DateTime(2017, 12, 12));
            ProductModel p2 = new ProductModel("C123", "pencil", 3, new DateTime(2017, 12, 11));
            ProductModel p3 = new ProductModel("D121", "bread", 4, new DateTime(2017, 12, 10));
            ProductModel p4 = new ProductModel("C123", "pencil", 1, new DateTime(2017, 12, 14));

            products.Add(p1);
            products.Add(p2);
            products.Add(p3);
            products.Add(p4);
        }

        public void InitBooks()
        {
            BookModel b1 = new BookModel("Harry Potter 1", "JK Rowlings", "123456f");
            BookModel b2 = new BookModel("Harry Potter 2", "JK Rowlings", "123456j");
            BookModel b3 = new BookModel("Harry Potter 3", "JK Rowlings", "123456j");

            books.Add(b1);
            books.Add(b2);
            books.Add(b3);
        }

        public void ShowMenu() 
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
            principalMenu.Show();
        }

        public void ReadClientChoice()
        {
            //Select options
            viewer.Show("Books or Products?");
            optionsBooksOrProducts = Console.ReadLine();
            viewer.Show("By What?");
            optionsParameters = Console.ReadLine();
        }

        public void Order()
        {
            //Show result
            viewer.Show("");
            viewer.Show("RESULT: ");
            if (optionsBooksOrProducts.Equals("1"))
            {
                IComparer<BookModel> bookComparer = new ObjectComparer<BookModel>(optionsParameters,bookPropertyComparerFactory);
                books.Sort(bookComparer);
            }
            else if (optionsBooksOrProducts.Equals("2"))
            {
                IComparer<ProductModel> productComparer = new ObjectComparer<ProductModel>(optionsParameters,productPropertyComparerFactory);
                products.Sort(productComparer);
            }
        }
    }
}
