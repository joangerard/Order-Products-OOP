using OrderProducts.Model;
using OrderProducts.Services;
using OrderProducts.Services.Product;
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
            this._productService = new ProductServiceEF();
        }

        [HttpGet]
        [ActionName("all")]
        public IHttpActionResult GetAllProducts(string options)
        {
            if (String.IsNullOrEmpty(options)) 
                return BadRequest("Parameter options cannot be null nor empty");
            return Ok(this._productService.GetAll(options));
        }

        [HttpGet]
        [ActionName("get")]
        public IHttpActionResult GetProductByCode(string code)
        {
            ProductModel model = this._productService.GetByCode(code);
            if (model == null) return NotFound();
            return Ok(model);
        }

        [HttpPost]
        [ActionName("new")]
        public IHttpActionResult CreateProduct(ProductModel product)
        {
            if (this._productService.GetByCode(product.Code) == null)
                return BadRequest("Code already exists");
            return Ok(this._productService.Create(product));
        }

        
    }
}