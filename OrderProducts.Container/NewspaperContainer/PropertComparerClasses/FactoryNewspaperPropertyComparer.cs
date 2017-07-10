using OrderProducts.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Container
{
    public class FactoryNewspaperPropertyComparer:IPropertyComparerFactory<NewspaperModel>
    {
        public FactoryNewspaperPropertyComparer() { }
        public IComparer<NewspaperModel> Create(string optionOrder, string optionType)
        {
            switch (optionType)
            {
                case "1":
                    return new NewspaperTitlePropertyComparer(optionOrder);
                case "2":
                    return new NewspaperPublicationDatePropertyComparer(optionOrder);
                default:
                    return new NewspaperTitlePropertyComparer(optionOrder);
            }
        }
    }
}
