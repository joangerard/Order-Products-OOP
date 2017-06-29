using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderProducts
{
    class Code:IPropertyManager
    {
        public bool IsGreater(Product product1, Product product2)
        {
            return String.Compare(product1.code, product2.code) > 0;
        }

        public bool Equal(Product product1, Product product2)
        {
            return String.Equals(product1.code, product2.code);
        }

        public bool IsLower(Product product1, Product product2)
        {
            return String.Compare(product1.code,product2.code)<0;
        }
    }
}
