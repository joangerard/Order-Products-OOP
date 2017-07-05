using OrderProducts.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Container
{
    public class ViewerConsole:IViewer
    {

        public void Show(string text)
        {
            Console.WriteLine(text);
        }

        public void ShowProducts(IList<Product> products)
        {
            Console.WriteLine("-------PRODUCTS---------------");
            foreach (var p in products)
            {
                Console.WriteLine("{0} {1} {2} {3}", p.Code, p.Name, p.Stock, p.ExpirationDate);
            }
        }

        public void ShowBooks(IList<Book> books)
        {
            Console.WriteLine("-------BOOKS---------------");
            foreach (var b in books)
            {
                Console.WriteLine("{0} {1} {2}", b.Name, b.Author, b.Isbn);
            }
        }
    }
}
