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
    public class MagazineController : ApiController
    {
        IPapersService<MagazineModel> _magazineService;

        public MagazineController()
        {
            _magazineService = new MagazineServiceEF();
        }

        [HttpGet]
        [ActionName("all")]
        public IHttpActionResult GetAllMagazines(string options)
        {
            if (String.IsNullOrEmpty(options))
                return BadRequest("Parameter options cannot be null nor empty");
            return Ok(_magazineService.GetAll(options));
        }

        [HttpPost]
        [ActionName("new")]
        public IHttpActionResult Create(MagazineModel magazine)
        {
            return Ok(_magazineService.Create(magazine));
        }
    }
}