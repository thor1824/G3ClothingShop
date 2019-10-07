using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClothShop.Core.ApplicationServices;
using ClothShop.Core.ApplicationServices.Impl;
using ClothShop.Core.Entity;
using ClothShop.Core.Entity.Enum;
using Microsoft.AspNetCore.Mvc;

namespace ClothShop.RestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SizesController : ControllerBase
    {

        private readonly ISizeService _service;
        public SizesController(ISizeService service)
        {
            _service = service;
        }

        // GET api/sizes
        [HttpGet]
        public ActionResult<IEnumerable<ClothingSize>> Get()
        {
            try
            {
                return Ok(_service.ReadAll());
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
            
        }

        // GET api/sizes/5
        [HttpGet("{id}")]
        public ActionResult<ClothingSize> Get(int id)
        {
            try
            {
                return Ok(_service.Read(id));
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
            
        }

        // POST api/sizes
        [HttpPost]
        public ActionResult<ClothingSize> Post([FromBody] ClothingSize value)
        {
            try
            {
                return Ok(_service.Create(value));
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        // PUT api/sizes/5
        [HttpPut("{id}")]
        public ActionResult<ClothingSize> Put(int id, [FromBody] ClothingSize value)
        {
            try
            {
                value.id = id;
                return Ok(_service.Update(value));
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        // DELETE api/sizes/5
        [HttpDelete("{id}")]
        public ActionResult<ClothingSize> Delete(int id)
        {
            try
            {
                return Ok(_service.Delete(id));
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
            
        }
    }
}
