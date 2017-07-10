using OrderProducts.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProducts.Repository.Interfaces
{
    public interface IPapersRepository<T>
    {
        List<T> GetAllByPaperType(int paperType);
        int Create(PapersEntity paper);
    }
}
