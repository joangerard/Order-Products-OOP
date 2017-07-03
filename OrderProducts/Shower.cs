using Container;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProducts
{
    public class Shower
    {
        public static void ShowStringConsole(string a)
        {
            Console.WriteLine(a);
        }

        public static void ShowBooksConsole(ObjectListBase<Book> books)
        {
            Console.WriteLine("-------BOOKS---------------");
            books.ForEach(b => Console.WriteLine("{0} {1} {2}", b.Name, b.Author, b.Isbn));
        }

        public static void ShowProductsConsole(ObjectListBase<Product> products)
        {
            Console.WriteLine("-------PRODUCTS---------------");
            products.ForEach(p => Console.WriteLine("{0} {1} {2} {3}",p.Code,p.Name,p.Stock,p.ExpirationDate));
        }
    }
}
