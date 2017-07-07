using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProducts.Repository.Entities
{
    public class StoreEntity
    {
        [Key]
        public int StoreId { get; set; }

        [Required]
        [MaxLength(100,ErrorMessage = "Store Name must be 100 characters or less")]
        public string Name { get; set; }
        public string Address { get; set; }
        public ICollection<BookEntity> Books { get; set; }
        public ICollection<ProductEntity> Products { get; set; }
    }
}
