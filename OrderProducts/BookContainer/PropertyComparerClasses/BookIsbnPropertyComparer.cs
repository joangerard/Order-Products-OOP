

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Container
{
    class BookIsbnPropertyComparer:IObjectPropertyComparer<Book>
    {
        bool IObjectPropertyComparer<Book>.Equal(Book b1, Book b2)
        {
            return String.Compare(b1.Isbn, b2.Isbn) == 0;
        }

        bool IObjectPropertyComparer<Book>.IsGreater(Book b1, Book b2)
        {
            return String.Compare(b1.Isbn, b2.Isbn) > 0;
        }

        bool IObjectPropertyComparer<Book>.IsLower(Book b1, Book b2)
        {
            return String.Compare(b1.Isbn, b2.Isbn) < 0;
        }
    }
}
