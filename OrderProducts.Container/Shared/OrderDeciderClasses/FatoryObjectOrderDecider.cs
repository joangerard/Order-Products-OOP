
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Container
{
    public class FatoryObjectPropertyOrderDecider<TObject>
    {
        string option;
        IObjectPropertyComparer<TObject> type;

        public FatoryObjectPropertyOrderDecider()
        {
            this.option = "A";
            this.type = new ObjectNotDefinedPropertyComparer<TObject>();
        }

        public void SetOption(string option)
        {
            this.option = option;
        }

        public void SetType(IObjectPropertyComparer<TObject> type)
        {
            this.type = type;
        }

        public IObjectOrderDecider<TObject> Create()
        {
            switch (option)
            {
                case "A":
                    return new ObjectPropertyOrderAscending<TObject>(this.type);
                case "D":
                    return new ObjectPropertyOrderDescending<TObject>(this.type);
                default:
                    return new ObjectPropertyOrderDefault<TObject>();
            }
        }
    }
}
