
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Container
{
    class ObjectPropertyOrderAscending<T>:ObjectPropertyOrderDeciderBase<T>
    {
        public ObjectPropertyOrderAscending(IObjectPropertyComparer<T> type)
        {
            this.type = type;
        }

        public override bool OrderDecided(T p1, T p2)
        {
            return this.type.IsGreater(p1,p2);
        }
    }
}
