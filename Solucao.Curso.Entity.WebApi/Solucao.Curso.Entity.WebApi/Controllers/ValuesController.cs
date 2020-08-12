using Microsoft.AspNetCore.Mvc;
using Solucao.Curso.Entity.Dominio.Models;
using Solucao.Curso.Entity.Repository.Data;
using System.Collections.Generic;
using System.Linq;

namespace Solucao.Curso.Entity.WebApi.Controllers
{
    [Route("api/ValuesController")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly HeroisContext _context;

        public ValuesController(HeroisContext context)
        {
          _context = context;
        }

        // GET: api/ValuesController
        [HttpGet]
        public ActionResult Get()
        {
            // return Ok(_context.Herois.ToList());
            return Ok((from heroi in _context.Herois select heroi).ToList());
        }

        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            // return Ok(_context.Herois.ToList());
            return Ok((from heroi in _context.Herois select heroi).Where(x => x.Id == id).ToList());
        }

        // GET api/ValuesController/5
        [HttpGet("{heroiName}")]
        public ActionResult Get(string heroiName)
        {
            var heroi = new Heroi
            {
                Nome = heroiName
            };

           _context.Herois.Add(heroi);
           _context.SaveChanges();
            

            return Ok();
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
