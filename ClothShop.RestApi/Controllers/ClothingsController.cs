using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClothShop.Core.ApplicationServices;
using ClothShop.Core.ApplicationServices.Impl;
using ClothShop.Core.Entity;
using Microsoft.AspNetCore.Mvc;

namespace ClothShop.RestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClothingsController : ControllerBase
    {

        private readonly IClothService _clothService;
        public ClothingsController(IClothService clothService)
        {
            _clothService = clothService;
        }

        // GET api/clothings
        [HttpGet]
        public ActionResult<IEnumerable<ClothingArticle>> Get()
        {
            try
            {
                return _clothService.ReadAll();
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
            
        }

        // GET api/clothings/5
        [HttpGet("{id}")]
        public ActionResult<ClothingArticle> Get(int id)
        {
            try
            {
                return Ok(_clothService.Read(id));
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
            
        }

        // POST api/clothings
        [HttpPost]
        public ActionResult<ClothingArticle> Post([FromBody] ClothingArticle value)
        {
            try
            {
                return Ok(_clothService.Create(value));
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        // PUT api/clothings/5
        [HttpPut("{id}")]
        public ActionResult<ClothingArticle> Put(int id, [FromBody] ClothingArticle value)
        {
            try
            {
                value.Id = id;
                return Ok(_clothService.Update(value));
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        // DELETE api/clothings/5
        [HttpDelete("{id}")]
        public ActionResult<ClothingArticle> Delete(int id)
        {
            try
            {
                return Ok(_clothService.Delete(id));
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
            
        }
    }
}
