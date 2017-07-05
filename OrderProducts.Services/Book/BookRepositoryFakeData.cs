using OrderProducts.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Container;

namespace OrderProducts.Services
{
    public class BookRepositoryFakeData:IBookRepository
    {
        Interpreter<Book> _bookInterpreter;
        IPropertyComparerFactory<Book> _bookPropertyComparerFactory;

        public BookRepositoryFakeData()
        {
            _bookPropertyComparerFactory = new FactoryBookPropertyComparer();
            _bookInterpreter = new Interpreter<Book>(_bookPropertyComparerFactory,"1-A");
        }

        public List<Model.Book> GetAll(string orderOptions)
        {
            List<Book> books = new List<Book>();
            Book b1 = new Book("Harry Potter 1", "JK Rowlings", "123456f");
            Book b2 = new Book("Harry Potter 2", "JK Rowlings", "123456j");
            Book b3 = new Book("Harry Potter 3", "JK Rowlings", "123456j");

            books.Add(b1);
            books.Add(b2);
            books.Add(b3);

            List<IComparer<Book>> propertyComparers = _bookInterpreter.Translate(orderOptions);
            IComparer<Book> bookComparer = new ObjectComparer<Book>(propertyComparers);
            books.Sort(bookComparer);

            return books;
        }
    }
}
