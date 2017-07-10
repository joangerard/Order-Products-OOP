using OrderProducts.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Container
{
    public class NewspaperPublicationDatePropertyComparer:IComparer<NewspaperModel>
    {
        string _order;

        public NewspaperPublicationDatePropertyComparer(string order)
        {
            this._order = order;
        }
        public int Compare(NewspaperModel x, NewspaperModel y)
        {
            int a;
            a = DateTime.Compare(x.PublicationDate, y.PublicationDate);
            if (_order.Equals("D"))
            {
                a *= -1;
            }
            return a;
        }
    }
}
