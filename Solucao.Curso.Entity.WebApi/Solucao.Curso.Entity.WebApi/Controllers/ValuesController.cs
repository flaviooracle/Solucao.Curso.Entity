using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Solucao.Curso.Entity.Dominio.Models;
using Solucao.Curso.Entity.Repository.Data;
using System.Collections;
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

        [HttpGet("ListaGet/")]
        public IEnumerable<Heroi> ListaGet()
        {
            // return Ok(_context.Herois.ToList());
            var lista = (from heroi in _context.Herois select heroi).ToList();

            return lista;
        }

        [HttpGet("filtro/{nome}")]
        public ActionResult GetHeroi(string nome)
        {
            // return Ok(_context.Herois.ToList());
            return Ok((from heroi in _context.Herois where heroi.Nome.Contains(nome) select heroi).ToList());
        }

        [HttpGet("codigo/{id}")]
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

        // Update api/ValuesController/5
        [HttpGet("atualize/{id}/{heroiName}")]
        public Heroi AtualizeGet(string heroiName, int id)
        {
            // o mesmo que alinha abaixo
            // var heroi = _context.Herois.Where(x => x.Id == id).FirstOrDefault();

            var response = (from heroi in _context.Herois where heroi.Id == id select heroi).
                FirstOrDefault();
            response.Nome = heroiName;

            _context.SaveChanges();


            return response;
        }

        // Delete api/ValuesController/5
        [HttpGet("delete/{id}")]
        public Heroi deleteGet(int id)
        {
            // o mesmo que alinha abaixo
            // var heroi = _context.Herois.Where(x => x.Id == id).FirstOrDefault();

            var response = (from heroi in _context.Herois where heroi.Id == id select heroi).
                FirstOrDefault();
           

            _context.Herois.Remove(response);

            _context.SaveChanges();


            return response;
        }


        // ADDRange api/ValuesController/5
        [HttpGet("addRange")]
        public List<string> addRange()
        {
            _context.AddRange(
                new Heroi { Nome = "Heroi 01" },
                new Heroi { Nome = "Heroi 02" },
                new Heroi { Nome = "Heroi 03" },
                new Heroi { Nome = "Heroi 04" },
                new Heroi { Nome = "Heroi 05" },
                new Heroi { Nome = "Heroi 06" }
                );

            _context.SaveChanges();
            // o mesmo que alinha abaixo
            var heroi = _context.Herois.Where(x => x.Id != null).Select(nome => nome.Nome).ToList();


            return heroi;
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
