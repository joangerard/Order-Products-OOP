
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProducts.Model
{
    public class BookModel
    {
        public int BookId { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Isbn { get; set; }
        public BookModel(string name,string author,string isbn)
        {
            this.Name = name;
            this.Author = author;
            this.Isbn = isbn;
        }

    }
}
