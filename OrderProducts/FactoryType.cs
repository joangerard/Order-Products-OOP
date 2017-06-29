using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProducts
{
    class FactoryType
    {
        string option;
        public FactoryType()
        {
            this.option = "1";
        }

        public void SetOption(string option)
        {
            this.option = option;
        }

        public IPropertyManager Create()
        {
            switch (option)
            {
                case "1":
                    return new Code();
                case "2":
                    return new Name();
                case "3":
                    return new Stock();
                default:
                    return new None();
            }
        }
    }
}
