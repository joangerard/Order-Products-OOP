

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Container
{
    class ProductCodeComparer:IObjectPropertyComparer<Product>
    {
        public bool IsGreater(Product product1, Product product2)
        {
            return String.Compare(product1.Code, product2.Code) > 0;
        }

        public bool Equal(Product product1, Product product2)
        {
            return String.Equals(product1.Code, product2.Code);
        }

        public bool IsLower(Product product1, Product product2)
        {
            return String.Compare(product1.Code, product2.Code) < 0;
        }
    }
}
