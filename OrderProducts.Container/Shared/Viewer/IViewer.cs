using OrderProducts.Model;
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
        void ShowProducts(IList<ProductModel> products);
        void ShowBooks(IList<BookModel> books);
    }
}
