using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProducts
{
    class None:IPropertyManager
    {
        public bool IsGreater(Product product1, Product product2)
        {
            return false;
        }

        public bool Equal(Product product1, Product product2)
        {
            return true;
        }

        public bool IsLower(Product product1, Product product2)
        {
            return false;
        }
    }
}
