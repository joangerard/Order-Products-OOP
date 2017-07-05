using Container;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProducts.Test.Viewer
{
    class ViewerTest:IViewer 
    {
        public void Show(string text)
        {
            throw new NotImplementedException();
        }

        public void ShowProducts(IList<Model.ProductModel> products)
        {
            throw new NotImplementedException();
        }

        public void ShowBooks(IList<Model.BookModel> books)
        {
            throw new NotImplementedException();
        }
    }
}
