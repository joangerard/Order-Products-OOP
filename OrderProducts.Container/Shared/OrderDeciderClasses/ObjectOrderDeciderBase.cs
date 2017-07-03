
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Container
{
    abstract class ObjectPropertyOrderDeciderBase<T>:IObjectOrderDecider<T>
    {
        public IObjectPropertyComparer<T> type;
        public abstract bool OrderDecided(T p1, T p2);
        public bool EqualValues(T p1, T p2)
        {
            return type.Equal(p1, p2);
        }

    }
}
