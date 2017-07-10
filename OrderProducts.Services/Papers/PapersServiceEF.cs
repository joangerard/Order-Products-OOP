using Container;
using OrderProducts.Model;
using OrderProducts.Repository.Entities;
using OrderProducts.Repository.Interfaces;
using OrderProducts.Repository.Repositories;
using OrderProducts.Services.Mapper;
using OrderProducts.Services.Papers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProducts.Services.Book
{
    internal class PapersServiceEF<T> : IPapersService<T>
    {
        IPapersRepository<PapersEntity> _paperRepo;
        MapperList<T, PapersEntity> _mapList;
        IPropertyComparerFactory<T> _bookPropertyComparerFactory;
        IMapper<T, PapersEntity> _mapper;
        IComparer<T> _bookComparer;
        int _type;
        public PapersServiceEF(IPropertyComparerFactory<T> _propertyComparerFactory,IMapper<T, PapersEntity> mapper,int type)
        {
            _paperRepo = new PapersRepositoryEF();
            _mapList = new MapperList<T, PapersEntity>();
            _mapper = mapper;
            _bookPropertyComparerFactory = _propertyComparerFactory;
            _type = type;
        }
        public List<T> GetAll(string orderOptions)
        {
            List<PapersEntity> papers = _paperRepo.GetAllByPaperType(_type);
            List<T> books = new List<T>();
            books = _mapList.Map(papers, _mapper.Map);
            _bookComparer = new ObjectComparer<T>(orderOptions, _bookPropertyComparerFactory);
            books.Sort(_bookComparer);
            return books;
        }

        public int Create(T paperModel)
        {
            PapersEntity papersEntity = _mapper.Map(paperModel);
            return _paperRepo.Create(papersEntity);
        }
    }
}
