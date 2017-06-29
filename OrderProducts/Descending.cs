using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderProducts
{
    class Descending:IOrderManager
    {
        
        public Descending(IPropertyManager type)
        {
            this.type = type;
        }

        
        public override bool DifferentValues(Product p1, Product p2)
        {
            return this.type.IsLower(p1,p2);
        }

    }
}
