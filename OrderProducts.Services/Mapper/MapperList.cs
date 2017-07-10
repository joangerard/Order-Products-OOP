using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProducts.Services.Mapper
{
    public class MapperList<T,F>
    {
        public List<T> Map(List<F> o, Func<F, T> map)
        {
            List<T> list = new List<T>();
            o.ForEach(p => list.Add(map(p)));
            return list;
        }
    }
}
