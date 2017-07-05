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
        IBookService _bookRepo;

        public BookController()
        {
            _bookRepo = new BookServiceFakeData();
        }

        [HttpGet]
        [ActionName("all")]
        public List<BookModel> GetAllBooks(string options)
        {
            return _bookRepo.GetAll(options);
        }
    }
}