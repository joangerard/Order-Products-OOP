using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Container
{
    public interface IPropertyComparerFactory<T>
    {
        IComparer<T> Create(string optionOrder, string optionType);
    }
}
