

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Container
{
    public class ProductNameComparer:IComparer<Product>
    {
        string _order; //A or D

        public ProductNameComparer(string order)
        {
            this._order = order;
        }

        public int Compare(Product x, Product y)
        {
            int a;
            a = String.Compare(x.Name, y.Name);
            if (_order.Equals("D"))
            {
                a *= -1;
            }
            return a;
        }
    }
}
