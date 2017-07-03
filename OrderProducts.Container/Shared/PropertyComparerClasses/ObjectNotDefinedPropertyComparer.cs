using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Container
{
    class ObjectNotDefinedPropertyComparer<T>:IObjectPropertyComparer<T>
    {
        public bool Equal(T p1, T p2)
        {
            return false;
        }

        public bool IsGreater(T p1, T p2)
        {
            return true;
        }

        public bool IsLower(T p1, T p2)
        {
            return false;
        }
    }
}
