using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Container
{
    public interface IFactoryObjectPropertyComparer<TObject>
    {
        void SetOption(string option);
        IObjectPropertyComparer<TObject> Create();
    }
}
