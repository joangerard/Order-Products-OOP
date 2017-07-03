
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Container
{
    class ObjectPropertyOrderDescending<TObject> : ObjectPropertyOrderDeciderBase<TObject>
    {

        public ObjectPropertyOrderDescending(IObjectPropertyComparer<TObject> type)
        {
            this.type = type;
        }


        public override bool OrderDecided(TObject p1, TObject p2)
        {
            return this.type.IsLower(p1,p2);
        }

    }
}
