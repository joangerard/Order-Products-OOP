using OrderProducts.Model;
using OrderProducts.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace OrderProducts.API.Controllers
{
    public class BookController : ApiController
    {
        IBookRepository _bookRepo;

        public BookController()
        {
            _bookRepo = new BookRepositoryFakeData();
        }
        // GET: Book
        public List<Book> Get()
        {
            return _bookRepo.GetAll();
        }
    }
}