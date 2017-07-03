using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Container
{
    public interface IObjectPropertyComparer<T>
    {
        bool Equal(T p1, T p2);
        bool IsGreater(T p1, T p2);
        bool IsLower(T p1, T p2);
    }
}
