

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Container
{
    class ProductExpirationDateComparer:IObjectPropertyComparer<Product>
    {
        public bool Equal(Product p1, Product p2)
        {
            return DateTime.Compare(p1.ExpirationDate, p2.ExpirationDate) == 0;
        }
        public bool IsGreater(Product p1, Product p2)
        {
            return DateTime.Compare(p1.ExpirationDate, p2.ExpirationDate) > 0;
        }
        public bool IsLower(Product p1, Product p2)
        {
            return DateTime.Compare(p1.ExpirationDate, p2.ExpirationDate) < 0;
        }
    }
}
