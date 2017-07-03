

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Container
{
    public class BookNamePropertyComparer:IObjectPropertyComparer<Book>
    {
        bool IObjectPropertyComparer<Book>.Equal(Book b1, Book b2)
        {
            return String.Compare(b1.Name, b2.Name) == 0;
        }

        bool IObjectPropertyComparer<Book>.IsGreater(Book b1, Book b2)
        {
            return String.Compare(b1.Name, b2.Name) > 0;
        }

        bool IObjectPropertyComparer<Book>.IsLower(Book b1, Book b2)
        {
            return String.Compare(b1.Name, b2.Name) < 0;
        }

    }
}
