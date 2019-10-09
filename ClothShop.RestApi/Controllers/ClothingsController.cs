using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClothShop.Core.ApplicationServices;
using ClothShop.Core.ApplicationServices.Impl;
using ClothShop.Core.Entity;
using ClothShop.Core.Entity.Enum;
using ClothShop.RestApi.DTO;
using Microsoft.AspNetCore.Mvc;

namespace ClothShop.RestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClothingsController : ControllerBase
    {

        private readonly IClothService _clothService;
        private readonly ITypeService _ts;
        private readonly IColorService _cs;
        private readonly ISizeService _ss;
        public ClothingsController(IClothService clothService, ITypeService ts, IColorService cs, ISizeService ss)
        {
            _clothService = clothService;
            _ts = ts;
            _cs = cs;
            _ss = ss;
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
                Console.WriteLine(  e.StackTrace);
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
        public ActionResult<ClothingArticle> Post([FromBody] DTOCreateCloth value)
        {
            try
            {
                ClothingArticle ca = new ClothingArticle()
                {
                    Size = _ss.Read(value.size),
                    ClothingType = _ts.Read(value.size),
                    Price = value.Price,
                    ImageUrl = value.ImageUrl,
                    Gender = (ClothingGender)value.Gender
                    
                };
                List<ClothColor> list = new List<ClothColor>();
                foreach (var item in value.colors)
                {
                    list.Add(new ClothColor()
                    {
                        Color = _cs.Read(item)
                    }
                    ); 
                }
                ca.Color = list;

                return Ok(_clothService.Create(ca));
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        // PUT api/clothings/5
        [HttpPut("{id}")]
        public ActionResult<ClothingArticle> Put(int id, [FromBody] DTOUpdateCloth value)
        {
            try
            {
                ClothingArticle ca = _clothService.Read(id);

                ca.Size = _ss.Read(value.size);
                ca.ClothingType = _ts.Read(value.ClothingType);
                ca.Price = value.Price;
                ca.ImageUrl = value.ImageUrl;
                ca.Gender = (ClothingGender)value.Gender;


                List<ClothColor> list = new List<ClothColor>();
                foreach (var item in value.colors)
                {
                    list.Add(new ClothColor()
                    {
                        Color = _cs.Read(item)
                    }
                    );
                }
                ca.Color = list;

                return Ok(_clothService.Update(ca));
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
