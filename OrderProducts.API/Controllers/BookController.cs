using OrderProducts.Model;
using OrderProducts.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace OrderProducts.API.Controllers
{
    public class BookController : ApiController
    {
        IBookRepository _bookRepo;

        public BookController()
        {
            _bookRepo = new BookRepositoryFakeData();
        }

        [HttpGet]
        [ActionName("all")]
        public List<Book> GetAllBooks(string options)
        {
            return _bookRepo.GetAll(options);
        }
    }
}