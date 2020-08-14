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
        public IEnumerable<Heroi> Get()
        {
            try
            {
                return _heroiExecute.ListHerois();
            }
            catch (Exception e)
            {
                return null;
            }

        }


        // GET api/<HeroiController>/5
        [HttpGet("{id}")]
        public HeroiResponse Get(int id)
        {
            return _heroiExecute.ListHerois(id);
        }

        // POST api/<HeroiController>
        [HttpPost]
        public IActionResult Post([FromBody] HeroiRequest request)
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
        public IActionResult Put([FromBody] HeroiRequest request)
        {
            try
            {
                
                var response = _heroiExecute.UpdateHeroi(request);

                if (response.heroi != null) 
                {
                    var LHeroi = _heroiExecute.ListHerois(response.heroi.Id).heroi;
                    return Ok("O Heroi: " + LHeroi.Nome + " foi atualizado  !!!!");
                }
                else
                    return Ok("Erro na Atualização  !!!!");
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
