using OrderProducts.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Container
{
    public class MagazineTypePropertyComparer:IComparer<MagazineModel>
    {
        string _order;

        public MagazineTypePropertyComparer(string order)
        {
            this._order = order;
        }

        public int Compare(MagazineModel x, MagazineModel y)
        {
            int a;
            a = String.Compare(x.Type, y.Type);
            if (_order.Equals("D"))
            {
                a *= -1;
            }
            return a;
        }
    }
}
