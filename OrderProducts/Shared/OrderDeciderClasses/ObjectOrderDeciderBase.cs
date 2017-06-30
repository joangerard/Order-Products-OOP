
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Container
{
    abstract class ObjectPropertyOrderDeciderBase<TObject>:IObjectOrderDecider<TObject>
    {
        public IObjectPropertyComparer<TObject> type;
        public abstract bool OrderDecided(TObject p1, TObject p2);
        public bool EqualValues(TObject p1, TObject p2)
        {
            return type.Equal(p1, p2);
        }

    }
}
