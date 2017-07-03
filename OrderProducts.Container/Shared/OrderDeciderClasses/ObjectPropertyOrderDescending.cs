
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Container
{
    class ObjectPropertyOrderDescending<T> : ObjectPropertyOrderDeciderBase<T>
    {

        public ObjectPropertyOrderDescending(IObjectPropertyComparer<T> type)
        {
            this.type = type;
        }


        public override bool OrderDecided(T p1, T p2)
        {
            return this.type.IsLower(p1,p2);
        }

    }
}
