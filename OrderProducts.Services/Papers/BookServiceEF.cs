using Container;
using OrderProducts.Model;
using OrderProducts.Repository.Entities;
using OrderProducts.Services.Book;
using OrderProducts.Services.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProducts.Services.Papers
{
    public class BookServiceEF:IPapersService<BookModel>
    {
        IPapersService<BookModel> _paperService;
        IPropertyComparerFactory<BookModel> _bookComparerFactory;
        IMapper<BookModel,PapersEntity> _mapper;

        public BookServiceEF()
        {
            _bookComparerFactory = new FactoryBookPropertyComparer();
            _mapper = new BookMapper();
            _paperService = new PapersServiceEF<BookModel>(_bookComparerFactory, _mapper,PaperType.Book);
        }

        public List<BookModel> GetAll(string options)
        {
            return _paperService.GetAll(options);
        }

        public int Create(BookModel bookModel)
        {
            return _paperService.Create(bookModel);
        }
    }
}
