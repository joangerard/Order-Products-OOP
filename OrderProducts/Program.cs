



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
            //Product p1 = new Product("A122", "bread", 4, new DateTime(2017, 12, 12));
            //Product p2 = new Product("C123", "pencil", 3, new DateTime(2017, 12, 11));
            //Product p3 = new Product("D121", "bread", 4, new DateTime(2017, 12, 10));
            //Product p4 = new Product("C123", "pencil", 1, new DateTime(2017, 12, 14));

            //Book b1 = new Book("Harry Potter 1", "JK Rowlings", "123456f");
            //Book b2 = new Book("Harry Potter 2", "JK Rowlings", "123456j");
            //Book b3 = new Book("Harry Potter 3", "JK Rowlings", "123456j");

            //ObjectListBase<Book> books = new BookList();
            //ObjectListBase<Product> products = new ProductList();

            //IFactoryObjectPropertyComparer<Book> factoryBookObjectComparer = new FactoryBookPropertyComparer();
            //IFactoryObjectPropertyComparer<Product> factoryProductObjectComparer = new FactoryProductPropertyComparer();
            //Translator<Product> translatorProducts = new Translator<Product>(factoryProductObjectComparer,"1-A");
            //Translator<Book> translatorBooks = new Translator<Book>(factoryBookObjectComparer, "2-A");

            
            //products.Add(p1);
            //products.Add(p2);
            //products.Add(p3);
            //products.Add(p4);


            
            //books.Add(b1);
            //books.Add(b2);
            //books.Add(b3);
            

            //while (true)
            //{

            //    Console.WriteLine("----------------Books------------------------");
            //    Shower.ShowBooksConsole(books);
            //    Console.WriteLine();
            //    Console.WriteLine("----------------Products------------------------");
            //    Shower.ShowProductsConsole(products);
                

            //    Console.WriteLine();
            //    Console.WriteLine("_____________________");
            //    Console.WriteLine("1 Books");
            //    Console.WriteLine("2 Products");
            //    Console.WriteLine("Select an option: ");

            //    string optionsObject = Console.ReadLine();
            //    string optionsParameters = "";
                

            //    if (optionsObject.Equals("1"))
            //    {
            //        Console.WriteLine("_____________________");
            //        Console.WriteLine("1 By Name");
            //        Console.WriteLine("2 By Author");
            //        Console.WriteLine("3 By Isbn");

            //    }
            //    else if (optionsObject.Equals("2"))
            //    {

            //        Console.WriteLine("_____________________");
            //        Console.WriteLine("1 By Code");
            //        Console.WriteLine("2 By Name");
            //        Console.WriteLine("3 By Stock");
            //        Console.WriteLine("4 By Expiration Date");
            //        Console.WriteLine("Your options: ");

            //    }

            //    optionsParameters = Console.ReadLine();

            //    Console.WriteLine();
            //    Console.WriteLine("RESULT: ");

            //    if (optionsObject.Equals("1"))
            //    {
            //        List<IObjectOrderDecider<Book>> orders = translatorBooks.Translate(optionsParameters);
            //        books.Order(orders);
            //        Shower.ShowBooksConsole(books);
            //    }
            //    else if (optionsObject.Equals("2"))
            //    {
            //        List<IObjectOrderDecider<Product>> orders = translatorProducts.Translate(optionsParameters);
            //        products.Order(orders);
            //        Shower.ShowProductsConsole(products);
            //    }


            //    Console.ReadKey();
            //    Console.Clear();
            //}


            BoxComponent pastaFerrari = new Product("1", "Pasta Ferrari", 200, new DateTime(2017, 10, 10));
            BoxComponent pastaZucaritas = new Product("2", "Pasta Zucaritas", 200, new DateTime(2017, 10, 10));
            BoxComponent pastaWhatEver = new Product("3", "Pasta WhatEver", 200, new DateTime(2017, 10, 10));
            BoxComponent pastas = new Box("Pastas", "All the pastas");
            
            pastas.Add(pastaFerrari);
            pastas.Add(pastaZucaritas);
            pastas.Add(pastaWhatEver);

            BoxComponent harryPotterBook1 = new Book("Harry Potter 1", "JK Rowlings", "123456");
            BoxComponent harryPotterBook2 = new Book("Harry Potter 2", "JK Rowlings", "123456");
            BoxComponent harryPotterBook3 = new Book("Harry Potter 3", "JK Rowlings", "123456");
            BoxComponent books = new Box("Books", "All my books");
            books.Add(harryPotterBook1);
            books.Add(harryPotterBook1);
            books.Add(harryPotterBook1);

            BoxComponent allThings = new Box("Things", "Books and Pastas");
            allThings.Add(books);
            allThings.Add(pastas);

            allThings.Print();

            Console.ReadKey();
        }
    }
}
