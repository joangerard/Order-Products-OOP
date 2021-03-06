﻿

using OrderProducts.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Container
{
    public class ProductCodeComparer : IComparer<ProductModel>
    {
        string _order; //A or D

        public ProductCodeComparer(string order)
        {
            this._order = order;
        }

        public int Compare(ProductModel x, ProductModel y)
        {
            int a;
            a = String.Compare(x.Code, y.Code);
            if (_order.Equals("D"))
            {
                a *= -1;
            }
            return a;
        }
    }
}
