

using OrderProducts.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Container
{
    public class BookIsbnPropertyComparer:IComparer<BookModel>
    {
        string _order; //A or D

        public BookIsbnPropertyComparer(string order)
        {
            this._order = order;
        }

        public int Compare(BookModel x, BookModel y)
        {
            int a;
            a = String.Compare(x.Isbn, y.Isbn);
            if (_order.Equals("D"))
            {
                a *= -1;
            }
            return a;
        }
    }
}
