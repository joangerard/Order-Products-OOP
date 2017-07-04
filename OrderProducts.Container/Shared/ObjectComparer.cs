using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Container
{
    public class ObjectComparer<T> : IComparer<T>
    {
        List<IComparer<T>> propertiesComparer;

        public ObjectComparer(List<IComparer<T>> propertiesComparer)
        {
            this.propertiesComparer = propertiesComparer;
        }

        public int Compare(T x, T y)
        {
            return Comparer(x, y,propertiesComparer);
        }

        private int Comparer<T>(T o1, T o2, List<IComparer<T>> propertyComparers)
        {
            int i;
            int response = 0;

            for (i = 0; i < propertyComparers.Count() && response==0; i++)
            {
                response = propertyComparers[i].Compare(o1,o2);
            }

            return response;
        }
    }
}
