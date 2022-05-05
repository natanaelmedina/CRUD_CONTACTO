using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webApi.Context;
using webApi.Models;
using Microsoft.EntityFrameworkCore;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace webApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    { 
         private readonly AppDbContext context;

        public ContactController(AppDbContext context)
        {
            this.context = context;
        }

        // GET api/<TestController>
        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok(context.Contacto.ToList());
            }
            catch (Exception ex)
            {

              return  BadRequest(ex.Message);
            }
        }

        // GET api/<TestController>/5
        [HttpGet("{id}", Name="getTest")]
        public ActionResult Get(int id)
        {
            try
            {
                var item = context.Contacto.FirstOrDefault(t => t.ContactoId == id);
                return Ok(item);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        // POST api/<TestController>
        [HttpPost]
        public ActionResult Post([FromBody] Contacto contacto)
        {
            try
            {
                context.Contacto.Add(contacto);
                context.SaveChanges();
                return CreatedAtRoute("getTest", new { id=contacto.ContactoId }, contacto);
       
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        // POST api/<TestController>
        [HttpPost]
        [Route("Multiple")]
        public ActionResult Post([FromBody] Contacto[] tests)
        {
            try
            {
                var items = new List<Contacto>();


                foreach (var item in tests)
                {
                    context.Contacto.Add(item);
                    context.SaveChanges();
                    items.Add(item);
                }
   
                return Ok(items.ToList());


            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        // PUT api/<TestController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Contacto contacto)
        {
            try
            {
               

                if (contacto.ContactoId == id )
                {
                    context.Entry(contacto).State = EntityState.Modified;
                    context.SaveChanges();
                    return CreatedAtRoute("getTest", new { id = contacto.ContactoId }, contacto);
                }
                return BadRequest($"No existe el id '{id}'");


            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<TestController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                var item = context.Contacto.FirstOrDefault(t => t.ContactoId == id);
                if(item !=null)
                {
                    context.Contacto.Remove(item);
                    context.SaveChanges();
                    return Ok(id);
                }
                return BadRequest($"No existe el id '{id}'");
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}
