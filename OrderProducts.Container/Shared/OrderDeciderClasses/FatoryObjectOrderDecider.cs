
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Container
{
    public class FatoryObjectPropertyOrderDecider<T>
    {
        public FatoryObjectPropertyOrderDecider()
        {
        }

        public IObjectOrderDecider<T> Create(string option,IObjectPropertyComparer<T> type)
        {
            switch (option)
            {
                case "A":
                    return new ObjectPropertyOrderAscending<T>(type);
                case "D":
                    return new ObjectPropertyOrderDescending<T>(type);
                default:
                    return new ObjectPropertyOrderDefault<T>();
            }
        }
    }
}
