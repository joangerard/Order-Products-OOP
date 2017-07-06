using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProducts.Services.Mapper
{
    public interface IMapper<T,F>
    {
        T Map(F o);
        F Map(T o);
    }
}
