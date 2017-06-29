using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderProducts
{
    class Ascending:IOrderManager
    {
        public Ascending(IPropertyManager type)
        {
            this.type = type;
        }

        public override bool DifferentValues(Product p1, Product p2)
        {
            return this.type.IsGreater(p1,p2);
        }
    }
}
