﻿using Container;
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
        List<Product> products;
        List<Book> books;

        IPropertyComparerFactory<Book> bookPropertyComparerFactory;
        IPropertyComparerFactory<Product> productPropertyComparerFactory;
        Interpreter<Product> interpreterProducts;
        Interpreter<Book> interpreterBooks;
        string optionsBooksOrProducts;
        string optionsParameters;

        public StoreFacade(IViewer viewer)
        {
            this.viewer = viewer;
            this.products = new List<Product>();
            this.books = new List<Book>();

            this.bookPropertyComparerFactory = new FactoryBookPropertyComparer();
            this.productPropertyComparerFactory = new FactoryProductPropertyComparer();
            this.interpreterBooks = new Interpreter<Book>(bookPropertyComparerFactory, "2-A");
            this.interpreterProducts = new Interpreter<Product>(productPropertyComparerFactory, "1-A");

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
            Product p1 = new Product("A122", "bread", 4, new DateTime(2017, 12, 12));
            Product p2 = new Product("C123", "pencil", 3, new DateTime(2017, 12, 11));
            Product p3 = new Product("D121", "bread", 4, new DateTime(2017, 12, 10));
            Product p4 = new Product("C123", "pencil", 1, new DateTime(2017, 12, 14));

            products.Add(p1);
            products.Add(p2);
            products.Add(p3);
            products.Add(p4);
        }

        public void InitBooks()
        {
            Book b1 = new Book("Harry Potter 1", "JK Rowlings", "123456f");
            Book b2 = new Book("Harry Potter 2", "JK Rowlings", "123456j");
            Book b3 = new Book("Harry Potter 3", "JK Rowlings", "123456j");

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
                List<IComparer<Book>> propertyComparers = interpreterBooks.Translate(optionsParameters);
                IComparer<Book> bookComparer = new ObjectComparer<Book>(propertyComparers);
                books.Sort(bookComparer);
            }
            else if (optionsBooksOrProducts.Equals("2"))
            {
                List<IComparer<Product>> propertyComparers = interpreterProducts.Translate(optionsParameters);
                IComparer<Product> productComparer = new ObjectComparer<Product>(propertyComparers);
                products.Sort(productComparer);
            }
        }
    }
}
