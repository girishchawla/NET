using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreSPA.BLL;

namespace AspNetCoreSPA.Web.Controllers
{
    [Produces("application/json")]
    [Route("api/Pricelist")]
    public class PricelistController : Controller
    {
        private readonly IPricelistBLL _pricelistBLL;

        public PricelistController(IPricelistBLL pricelistBLL)
        {
            _pricelistBLL = pricelistBLL;
        }

        // GET: api/Pricelist
        [HttpGet]
        public IActionResult Get()
        {
            return Json(_pricelistBLL.GetAll());
        }

        // GET: api/Pricelist/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Json("value" + id);
        }

        // POST: api/Pricelist
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Pricelist/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
