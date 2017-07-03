
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Container
{
    public class FactoryBookPropertyComparer:IFactoryObjectPropertyComparer<Book>
    {
        public FactoryBookPropertyComparer()
        {
        }

        public IObjectPropertyComparer<Book> Create(string option)
        {
            switch (option)
            {
                case "1":
                    return new BookNamePropertyComparer();
                case "2":
                    return new BookAuthorPropertyComparer();
                case "3":
                    return new BookIsbnPropertyComparer();
                default:
                    return new ObjectNotDefinedPropertyComparer<Book>();
            }
        }


    }
}
