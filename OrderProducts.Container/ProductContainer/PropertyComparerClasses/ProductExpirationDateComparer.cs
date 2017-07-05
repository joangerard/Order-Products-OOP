

using OrderProducts.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Container
{
    public class ProductExpirationDateComparer : IComparer<ProductModel>
    {
       string _order; //A or D

       public ProductExpirationDateComparer(string order)
        {
            this._order = order;
        }

        public int Compare(ProductModel x, ProductModel y)
        {
            int a;
            a = DateTime.Compare(x.ExpirationDate, y.ExpirationDate);
            if (_order.Equals("D"))
            {
                a *= -1;
            }
            return a;
        }
    }
}
