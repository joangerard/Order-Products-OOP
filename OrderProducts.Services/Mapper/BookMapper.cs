using OrderProducts.Model;
using OrderProducts.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProducts.Services.Mapper
{
    public class BookMapper:IMapper<BookModel,PapersEntity>
    {
        public BookModel Map(PapersEntity papersEntity)
        {
            BookModel book = new BookModel(papersEntity.Name,papersEntity.Author,papersEntity.Isbn);
            book.BookId = papersEntity.BookId;
            return book;
        }

        public PapersEntity Map(BookModel bookModel)
        {
            PapersEntity papers = new PapersEntity
            {
                BookId = bookModel.BookId,
                Name = bookModel.Name,
                Author = bookModel.Author,
                Isbn = bookModel.Isbn,
                PaperType = PaperType.Book
            };
            return papers;
        }
    }
}

