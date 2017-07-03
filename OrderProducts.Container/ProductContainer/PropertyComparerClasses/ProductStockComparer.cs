

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Container
{
    class ProductStockComparer:IObjectPropertyComparer<Product>
    {
        public bool IsGreater(Product product1, Product product2)
        {
            return product1.Stock > product2.Stock;
        }

        public bool Equal(Product product1, Product product2)
        {
            return product1.Stock == product2.Stock;
        }

        public bool IsLower(Product product1, Product product2)
        {
            return product1.Stock < product2.Stock;
        }
    }
}
