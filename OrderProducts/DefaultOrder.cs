using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProducts
{
    class Default:IOrderManager
    {
        public Default()
        {
            this.type = new None();
        }

        public override bool DifferentValues(Product p1, Product p2)
        {
            return this.type.IsGreater(p1,p2);
        }
    }
}
