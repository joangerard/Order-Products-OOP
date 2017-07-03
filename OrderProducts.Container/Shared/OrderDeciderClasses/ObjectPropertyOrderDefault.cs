
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Container
{
    class ObjectPropertyOrderDefault<TObject> : ObjectPropertyOrderDeciderBase<TObject>
    {
        public ObjectPropertyOrderDefault()
        {
            this.type = new ObjectNotDefinedPropertyComparer<TObject>();
        }

        public override bool OrderDecided(TObject p1, TObject p2)
        {
            return this.type.IsGreater(p1,p2);
        }
    }
}
