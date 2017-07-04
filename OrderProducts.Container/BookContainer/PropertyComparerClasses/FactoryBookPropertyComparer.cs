using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Container;

namespace Container
{
    public class FactoryBookPropertyComparer : IPropertyComparerFactory<Book>
    {
        public IComparer<Book> Create(string optionOrder, string optionType)
        {
            switch (optionType)
            {
                case "1":
                    return new BookNamePropertyComparer(optionOrder);
                case "2":
                    return new BookAuthorPropertyComparer(optionOrder);
                case "3":
                    return new BookIsbnPropertyComparer(optionOrder);
                default:
                    return new BookNamePropertyComparer(optionOrder);
            }
        }
    }
}
