using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderProducts
{
    public interface IPropertyManager
    {
        bool Equal(Product p1, Product p2);
        bool IsGreater(Product p1, Product p2);
        bool IsLower(Product p1, Product p2);
    }
}
