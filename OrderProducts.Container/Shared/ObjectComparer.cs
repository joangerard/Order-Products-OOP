using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Container
{
    public class ObjectComparer<T> : IComparer<T>
    {
        List<IComparer<T>> _propertiesComparer;
        Interpreter<T> _interpreterOptions;
        IPropertyComparerFactory<T> _propertyComparerFactory;

        public ObjectComparer(string orderOptions, IPropertyComparerFactory<T> propertyComparerFactory)
        {
            this._propertyComparerFactory = propertyComparerFactory;
            this._interpreterOptions = new Interpreter<T>(_propertyComparerFactory, "1-A");
            this._propertiesComparer = _interpreterOptions.Translate(orderOptions);
        }

        public void SetOrderOptions(string orderOptions)
        {
            this._propertiesComparer = _interpreterOptions.Translate(orderOptions);
        }

        public int Compare(T x, T y)
        {
            return Comparer(x, y,_propertiesComparer);
        }

        private int Comparer(T o1, T o2, List<IComparer<T>> propertyComparers)
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
