using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Container
{
    public interface IObjectOrderDecider<T>
    {
        bool OrderDecided(T p1, T p2);
        bool EqualValues(T p1, T p2);
    }
}
