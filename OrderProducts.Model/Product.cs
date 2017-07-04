
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProducts.Model
{
    public class Product
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public DateTime ExpirationDate { get; set; }
        public Product(string code,string name,int stock,DateTime expirationDate)
        {
            this.Code = code;
            this.Name = name;
            this.Stock = stock;
            this.ExpirationDate = expirationDate;
        }
    }
}
