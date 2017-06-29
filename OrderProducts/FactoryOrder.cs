using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProducts
{
    class FactoryOrder
    {
        string option;
        IPropertyManager type;

        public FactoryOrder()
        {
            this.option = "A";
            this.type = new None();
        }

        public void SetOption(string option)
        {
            this.option = option;
        }

        public void SetType(IPropertyManager type)
        {
            this.type = type;
        }

        public IOrderManager Create()
        {
            switch (option)
            {
                case "A":
                    return new Ascending(this.type);
                case "D":
                    return new Descending(this.type);
                default:
                    return new Default();
            }
        }
    }
}
