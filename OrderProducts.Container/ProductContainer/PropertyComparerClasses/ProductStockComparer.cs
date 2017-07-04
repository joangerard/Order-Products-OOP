

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Container
{
    public class ProductStockComparer:IComparer<Product>
    {
        string _order; //A or D

        public ProductStockComparer(string order)
        {
            this._order = order;
        }

        public int Compare(Product x, Product y)
        {
            int a = 0;

            a = x.Stock.CompareTo(y.Stock);

            if (_order.Equals("D"))
            {
                a *= -1;
            }
            return a;
        }
    }
}
