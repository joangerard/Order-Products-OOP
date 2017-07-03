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

        public void ShowProducts(List<Product> products)
        {
            Console.WriteLine("-------PRODUCTS---------------");
            products.ForEach(p => Console.WriteLine("{0} {1} {2} {3}", p.Code, p.Name, p.Stock, p.ExpirationDate));
        }

        public void ShowBooks(List<Book> books)
        {
            Console.WriteLine("-------BOOKS---------------");
            books.ForEach(b => Console.WriteLine("{0} {1} {2}", b.Name, b.Author, b.Isbn));
        }
    }
}
