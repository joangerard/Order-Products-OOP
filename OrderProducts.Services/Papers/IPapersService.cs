using OrderProducts.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProducts.Services
{
    public interface IPapersService<T>
    {
        List<T> GetAll(string orderOptions);
        int Create(T paper);
    }
}
