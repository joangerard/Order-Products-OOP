
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Container
{
    class ObjectPropertyOrderAscending<TObject>:ObjectPropertyOrderDeciderBase<TObject>
    {
        public ObjectPropertyOrderAscending(IObjectPropertyComparer<TObject> type)
        {
            this.type = type;
        }

        public override bool OrderDecided(TObject p1, TObject p2)
        {
            return this.type.IsGreater(p1,p2);
        }
    }
}
