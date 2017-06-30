
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Container
{
    class FactoryProductPropertyComparer : IFactoryObjectPropertyComparer<Product>
    {
        string option;
        public FactoryProductPropertyComparer()
        {
            this.option = "1";
        }

        public void SetOption(string option)
        {
            this.option = option;
        }

        public IObjectPropertyComparer<Product> Create()
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
