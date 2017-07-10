using OrderProducts.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Container
{
    public class NewspaperTitlePropertyComparer:IComparer<NewspaperModel>
    {
        string _order;

        public NewspaperTitlePropertyComparer(string order)
        {
            this._order = order;
        }

        public int Compare(NewspaperModel x, NewspaperModel y)
        {
            int a;
            a = String.Compare(x.Title, y.Title);
            if (_order.Equals("D"))
            {
                a *= -1;
            }
            return a;
        }
    }
}
