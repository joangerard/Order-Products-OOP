
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Container
{
    class FactoryBookPropertyComparer:IFactoryObjectPropertyComparer<Book>
    {
        string option;

        public FactoryBookPropertyComparer()
        {
            this.option = "1";
        }

        public void SetOption(string option)
        {
            this.option = option;
        }

        public IObjectPropertyComparer<Book> Create()
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
