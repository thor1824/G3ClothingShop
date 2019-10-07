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
    public class ColorsController : ControllerBase
    {

        private readonly IColorService _service;
        public ColorsController(IColorService service)
        {
            _service = service;
        }

        // GET api/colors
        [HttpGet]
        public ActionResult<IEnumerable<ClothingColor>> Get()
        {
            try
            {
                return _service.ReadAll();
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
            
        }

        // GET api/colors/5
        [HttpGet("{id}")]
        public ActionResult<ClothingColor> Get(int id)
        {
            try
            {
                return _service.Read(id);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
            
        }

        // POST api/colors
        [HttpPost]
        public ActionResult<ClothingColor> Post([FromBody] ClothingColor value)
        {
            try
            {
                return _service.Create(value);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        // PUT api/colors/5
        [HttpPut("{id}")]
        public ActionResult<ClothingColor> Put(int id, [FromBody] ClothingColor value)
        {
            try
            {
                value.id = id;
                return _service.Update(value);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        // DELETE api/colors/5
        [HttpDelete("{id}")]
        public ActionResult<ClothingColor> Delete(int id)
        {
            try
            {
                return _service.Delete(id);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
            
        }
    }
}
