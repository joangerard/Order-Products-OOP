using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProducts
{
    public class Product
    {
        public string code { get; set; }
        public string name { get; set; }
        public int stock { get; set; }
        public Product(string code,string name,int stock)
        {
            this.code = code;
            this.name = name;
            this.stock = stock;
        }

        public void Show() 
        {
            Console.WriteLine("{0} {1} {2}",this.code,this.name,this.stock);
        }
    }
}
