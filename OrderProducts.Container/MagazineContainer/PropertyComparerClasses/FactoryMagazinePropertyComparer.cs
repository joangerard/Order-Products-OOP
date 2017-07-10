using OrderProducts.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Container
{
    public class FactoryMagazinePropertyComparer : IPropertyComparerFactory<MagazineModel>
    {
        public FactoryMagazinePropertyComparer() { }
        IComparer<MagazineModel> IPropertyComparerFactory<MagazineModel>.Create(string optionOrder, string optionType)
        {
            switch (optionType)
            {
                case "1":
                    return new MagazineTitlePropertyComparer(optionOrder);
                case "2":
                    return new MagazineTypePropertyComparer(optionOrder);
                default:
                    return new MagazineTitlePropertyComparer(optionOrder);
            }
        }
    }
}
