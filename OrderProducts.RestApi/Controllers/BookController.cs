using OrderProducts.Model;
using OrderProducts.Services;
using OrderProducts.Services.Papers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace OrderProducts.API.Controllers
{
    public class BookController : ApiController
    {
        IPapersService<BookModel> _bookService;

        public BookController()
        {
            _bookService = new BookServiceEF();
        }

        [HttpGet]
        [ActionName("all")]
        public IHttpActionResult GetAllBooks(string options)
        {
            if(String.IsNullOrEmpty(options)) 
                return BadRequest("Parameter options cannot be null nor empty");
            return Ok(_bookService.GetAll(options));
        }

        [HttpPost]
        [ActionName("new")]
        public IHttpActionResult Create(BookModel book)
        {
            return Ok(this._bookService.Create(book));
        }
    }
}