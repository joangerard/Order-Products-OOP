using OrderProducts.Model;
using OrderProducts.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace OrderProducts.API.Controllers
{
    public class ProductController : ApiController
    {
        IProductRepository _productService;

        public ProductController()
        {
            this._productService = new ProductRepositoryFakeData();
        }

        [HttpGet]
        [ActionName("all")]
        public List<Product> GetAllProducts(string options)
        {
            return this._productService.GetAll(options);
        }
    }
}