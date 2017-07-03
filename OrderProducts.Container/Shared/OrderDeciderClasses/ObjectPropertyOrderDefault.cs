
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Container
{
    class ObjectPropertyOrderDefault<T> : ObjectPropertyOrderDeciderBase<T>
    {
        public ObjectPropertyOrderDefault()
        {
            this.type = new ObjectNotDefinedPropertyComparer<T>();
        }

        public override bool OrderDecided(T p1, T p2)
        {
            return this.type.IsGreater(p1,p2);
        }
    }
}
