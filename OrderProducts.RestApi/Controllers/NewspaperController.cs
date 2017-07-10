using OrderProducts.Model;
using OrderProducts.Services;
using OrderProducts.Services.Papers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace OrderProducts.RestApi.Controllers
{
    public class NewspaperController : ApiController
    {
        IPapersService<NewspaperModel> _newspaperService;

        public NewspaperController()
        {
            _newspaperService = new NewspaperServiceEF();
        }

        [HttpGet]
        [ActionName("all")]
        public IHttpActionResult GetAllNewspapers(string options)
        {
            if (String.IsNullOrEmpty(options))
                return BadRequest("Parameter options cannot be null nor empty");
            return Ok(_newspaperService.GetAll(options));
        }

        [HttpPost]
        [ActionName("new")]
        public IHttpActionResult Create(NewspaperModel newspaper)
        {
            return Ok(_newspaperService.Create(newspaper));
        }
    }
}