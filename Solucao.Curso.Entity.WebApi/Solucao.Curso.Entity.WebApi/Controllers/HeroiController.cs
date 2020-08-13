using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solucao.Curso.Entity.Core.Operation.Interface;
using Solucao.Curso.Entity.Dominio.DataContracts.Request;
using Solucao.Curso.Entity.Dominio.DataContracts.Response;
using Solucao.Curso.Entity.Dominio.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Solucao.Curso.Entity.WebApi.Controllers
{   
    [Route("api/heroi")]
    [ApiController]
    public class HeroiController : ControllerBase
    {
        private readonly IHeroiExecute _heroiExecute;

        public HeroiController(IHeroiExecute heroiExecute)
        {
            _heroiExecute = heroiExecute;
        }

        // GET: api/<HeroiController>
        [HttpGet]
        public ActionResult Get()
        {
            List<string> response = new List<string>();
            try
            {
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest($"erro: {e}");
            }

        }


        // GET api/<HeroiController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<HeroiController>
        [HttpPost]
        public ActionResult Post([FromBody] HeroiRequest request)
        {
            try
            {
                var response = _heroiExecute.PostHeroi(request);

                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest($"erro: {e}");
            }
        }

        // PUT api/<HeroiController>/5
        [HttpPut]
        public ActionResult Put(int id, [FromBody] HeroiRequest request)
        {
            try
            {
                var response = _heroiExecute.UpdateHeroi(request);

                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest($"erro: {e}");
            }
        }

        // DELETE api/<HeroiController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
