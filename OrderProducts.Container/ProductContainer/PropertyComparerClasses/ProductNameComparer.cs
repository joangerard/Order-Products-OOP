

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Container
{
    class ProductNameComparer:IObjectPropertyComparer<Product>
    {
        public bool IsGreater(Product product1, Product product2)
        {
            return String.Compare(product1.Name, product2.Name) > 0;
        }

        public bool Equal(Product product1, Product product2)
        {
            return String.Compare(product1.Name, product2.Name) == 0;
        }

        public bool IsLower(Product product1, Product product2)
        {
            return String.Compare(product1.Name, product2.Name) < 0;
        }
    }
}
