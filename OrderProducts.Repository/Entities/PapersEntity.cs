using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProducts.Repository.Entities
{
    [Table("Papers")]
    public class PapersEntity
    {
        [Key]
        public int BookId { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Isbn { get; set; }
        public string Title { get; set; }
        public int Type { get; set; }

        private DateTime _publicationDate;
        public DateTime PublicationDate 
        { 
            get 
            {
                if (_publicationDate == DateTime.MinValue) 
                    return new DateTime(2000, 1, 1);
                return this._publicationDate; 
            }
            set
            {
                this._publicationDate = value;
            } 
        }
        public virtual StoreEntity Store { get; set; }
        public int PaperType { get; set; }
    }
}
