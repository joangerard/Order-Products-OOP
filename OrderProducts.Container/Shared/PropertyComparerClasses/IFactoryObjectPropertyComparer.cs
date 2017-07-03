using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Container
{
    public interface IFactoryObjectPropertyComparer<T>
    {
        IObjectPropertyComparer<T> Create(string option);
    }
}
