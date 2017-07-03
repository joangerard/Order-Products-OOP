
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Container
{
    public class FactoryProductPropertyComparer : IFactoryObjectPropertyComparer<Product>
    {
        public FactoryProductPropertyComparer()
        {
        }

        public IObjectPropertyComparer<Product> Create(string option)
        {
            switch (option)
            {
                case "1":
                    return new ProductCodeComparer();
                case "2":
                    return new ProductNameComparer();
                case "3":
                    return new ProductStockComparer();
                case "4":
                    return new ProductExpirationDateComparer();
                default:
                    return new ObjectNotDefinedPropertyComparer<Product>();
            }
        }
    }
}
