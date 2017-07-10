﻿using OrderProducts.Model;
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
        IPapersService<BookModel> _bookRepo;

        public BookController()
        {
            _bookRepo = new BookServiceEF();
        }

        [HttpGet]
        [ActionName("all")]
        public IHttpActionResult GetAllBooks(string options)
        {
            if(String.IsNullOrEmpty(options)) 
                return BadRequest("Parameter options cannot be null nor empty");
            return Ok(_bookRepo.GetAll(options));
        }
    }
}