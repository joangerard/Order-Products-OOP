using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Container
{
    public interface IViewer
    {
        void Show(string text);
        void ShowProducts(List<Product> products);
        void ShowBooks(List<Book> books);
    }
}
