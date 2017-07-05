using OrderProducts.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Container;

namespace OrderProducts.Services
{
    public class BookServiceFakeData:IBookService
    {
        Interpreter<BookModel> _bookInterpreter;
        IPropertyComparerFactory<BookModel> _bookPropertyComparerFactory;

        public BookServiceFakeData()
        {
            _bookPropertyComparerFactory = new FactoryBookPropertyComparer();
            _bookInterpreter = new Interpreter<BookModel>(_bookPropertyComparerFactory,"1-A");
        }

        public List<Model.BookModel> GetAll(string orderOptions)
        {
            List<BookModel> books = new List<BookModel>();
            BookModel b1 = new BookModel("Harry Potter 1", "JK Rowlings", "123456f");
            BookModel b2 = new BookModel("Harry Potter 2", "JK Rowlings", "123456j");
            BookModel b3 = new BookModel("Harry Potter 3", "JK Rowlings", "123456j");

            books.Add(b1);
            books.Add(b2);
            books.Add(b3);

            List<IComparer<BookModel>> propertyComparers = _bookInterpreter.Translate(orderOptions);
            IComparer<BookModel> bookComparer = new ObjectComparer<BookModel>(propertyComparers);
            books.Sort(bookComparer);

            return books;
        }
    }
}
