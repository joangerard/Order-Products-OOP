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
    public class ProductController : ApiController
    {
        IProductRepository _productService;

        public ProductController()
        {
            this._productService = new ProductRepositoryFakeData();
        }

        public List<Product> Get()
        {
            return this._productService.GetAll();
        }
    }
}