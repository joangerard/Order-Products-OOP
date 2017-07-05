using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProducts.Repository.Entities
{
    public class ProductEntity
    {
        [Key]
        public int ProductId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
