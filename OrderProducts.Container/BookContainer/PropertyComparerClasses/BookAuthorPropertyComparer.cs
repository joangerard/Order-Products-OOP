

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Container
{
    public class BookAuthorPropertyComparer : IComparer<Book>
    {
        string _order; //A or D

        public BookAuthorPropertyComparer(string order)
        {
            this._order = order;
        }

        public int Compare(Book x, Book y)
        {
            int a;
            a = String.Compare(x.Author, y.Author);
            if (_order.Equals("D"))
            {
                a *= -1;
            }
            return a;
        }
    }
}
