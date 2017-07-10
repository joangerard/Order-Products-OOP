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
    public class MagazineServiceEF:IPapersService<MagazineModel>
    {
        IPapersService<MagazineModel> _magazineService;
        IPropertyComparerFactory<MagazineModel> _magazineComparerFactory;
        IMapper<MagazineModel, PapersEntity> _mapper;

        public MagazineServiceEF()
        {
            _magazineComparerFactory = new FactoryMagazinePropertyComparer();
            _mapper = new MagazineMapper();
            _magazineService = new PapersServiceEF<MagazineModel>(_magazineComparerFactory, _mapper, PaperType.Magazine);
        }

        public List<MagazineModel> GetAll(string orderOptions)
        {
            return _magazineService.GetAll(orderOptions);
        }


        public int Create(MagazineModel paper)
        {
            return _magazineService.Create(paper);
        }
    }
}
