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
        IProductService _productService;

        public ProductController()
        {
            this._productService = new ProductServiceFakeData();
        }

        [HttpGet]
        [ActionName("all")]
        public List<ProductModel> GetAllProducts(string options)
        {
            return this._productService.GetAll(options);
        }
    }
}