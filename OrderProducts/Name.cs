using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderProducts
{
    class Name:IPropertyManager
    {
        public bool IsGreater(Product product1, Product product2)
        {
            return String.Compare(product1.name, product2.name) > 0;
        }

        public bool Equal(Product product1, Product product2)
        {
            return String.Equals(product1.name, product2.name);
        }

        public bool IsLower(Product product1, Product product2)
        {
            return String.Compare(product1.name, product2.name) < 0;
        }
    }
}
