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
    public class TypesController : ControllerBase
    {

        private readonly ITypeService _service;
        public TypesController(ITypeService service)
        {
            _service = service;
        }

        // GET api/types
        [HttpGet]
        public ActionResult<IEnumerable<ClothingType>> Get()
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

        // GET api/types/5
        [HttpGet("{id}")]
        public ActionResult<ClothingType> Get(int id)
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

        // POST api/types
        [HttpPost]
        public ActionResult<ClothingType> Post([FromBody] ClothingType value)
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

        // PUT api/types/5
        [HttpPut("{id}")]
        public ActionResult<ClothingType> Put(int id, [FromBody] ClothingType value)
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

        // DELETE api/types/5
        [HttpDelete("{id}")]
        public ActionResult<ClothingType> Delete(int id)
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
