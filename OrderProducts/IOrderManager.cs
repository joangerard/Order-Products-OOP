using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProducts
{
    public abstract class IOrderManager
    {
        public IPropertyManager type;
        public abstract bool DifferentValues(Product p1,Product p2);
        public bool EqualValues(Product p1, Product p2)
        {
            return type.Equal(p1, p2);
        }
    }
}
