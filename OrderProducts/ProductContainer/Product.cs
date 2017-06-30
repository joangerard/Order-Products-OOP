
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Container
{
    public class Product:BoxComponent
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

        public override void Print() 
        {
            Console.WriteLine("{0} {1} {2} {3}", this.Code, this.Name, this.Stock, this.ExpirationDate.ToString("yyyy/MM/dd"));
        }
    }
}
