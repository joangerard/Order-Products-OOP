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
    public class NewspaperServiceEF:IPapersService<NewspaperModel>
    {
        IPapersService<NewspaperModel> _paperService;
        IPropertyComparerFactory<NewspaperModel> _newspaperComparerFactory;
        IMapper<NewspaperModel, PapersEntity> _mapper;
        public NewspaperServiceEF()
        {
            _newspaperComparerFactory = new FactoryNewspaperPropertyComparer();
            _mapper = new NewspaperMapper();
            _paperService = new PapersServiceEF<NewspaperModel>(_newspaperComparerFactory, _mapper, PaperType.Newspaper);
        }
        public List<NewspaperModel> GetAll(string orderOptions)
        {
            return _paperService.GetAll(orderOptions);
        }


        public int Create(NewspaperModel paper)
        {
            return _paperService.Create(paper);
        }
    }
}
