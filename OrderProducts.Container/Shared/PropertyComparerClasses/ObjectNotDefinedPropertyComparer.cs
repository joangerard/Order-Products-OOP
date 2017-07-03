using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Container
{
    class ObjectNotDefinedPropertyComparer<TObject>:IObjectPropertyComparer<TObject>
    {
        public bool Equal(TObject p1, TObject p2)
        {
            return false;
        }

        public bool IsGreater(TObject p1, TObject p2)
        {
            return true;
        }

        public bool IsLower(TObject p1, TObject p2)
        {
            return false;
        }
    }
}
