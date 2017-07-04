using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Container
{
    public class FactoryProductPropertyComparer : IPropertyComparerFactory<Product>
    {
        public IComparer<Product> Create(string optionOrder, string optionType)
        {
            switch (optionType)
            {
                case "1":
                    return new ProductCodeComparer(optionOrder);
                case "2":
                    return new ProductNameComparer(optionOrder);
                case "3":
                    return new ProductStockComparer(optionOrder);
                case "4":
                    return new ProductExpirationDateComparer(optionOrder);
                default:
                    return new ProductCodeComparer(optionOrder);
            }
        }
    }
}
