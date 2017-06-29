using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderProducts
{
    class Stock:IPropertyManager
    {
        public bool IsGreater(Product product1, Product product2)
        {
            return product1.stock > product2.stock;
        }

        public bool Equal(Product product1, Product product2)
        {
            return product1.stock == product2.stock;
        }

        public bool IsLower(Product product1, Product product2)
        {
            return product1.stock < product2.stock;
        }
    }
}
