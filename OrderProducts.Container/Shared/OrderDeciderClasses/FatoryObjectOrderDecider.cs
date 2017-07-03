
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Container
{
    public class FatoryObjectPropertyOrderDecider<TObject>
    {
        public FatoryObjectPropertyOrderDecider()
        {
        }

        public IObjectOrderDecider<TObject> Create(string option,IObjectPropertyComparer<TObject> type)
        {
            switch (option)
            {
                case "A":
                    return new ObjectPropertyOrderAscending<TObject>(type);
                case "D":
                    return new ObjectPropertyOrderDescending<TObject>(type);
                default:
                    return new ObjectPropertyOrderDefault<TObject>();
            }
        }
    }
}
