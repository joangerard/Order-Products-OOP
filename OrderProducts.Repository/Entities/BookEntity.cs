using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProducts.Repository.Entities
{
    public class BookEntity
    {
        [Key]
        public int BookId { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }

        [MaxLength(20)]
        [Index(IsUnique = true)]
        public string Isbn { get; set; }
        public virtual StoreEntity Store { get; set; }
    }
}
