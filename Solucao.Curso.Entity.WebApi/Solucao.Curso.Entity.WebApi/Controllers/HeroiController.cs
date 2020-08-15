using Microsoft.AspNetCore.Mvc;
using Solucao.Curso.Entity.Core.Operation.Interface;
using Solucao.Curso.Entity.Dominio.DataContracts.Request;
using Solucao.Curso.Entity.Dominio.DataContracts.Response;
using Solucao.Curso.Entity.Dominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        public async Task<IEnumerable<Heroi>> Get()  // colocar o retono em dto para retorno
        {
            var res = await _heroiExecute.ListHerois();
           // res = res.Where(x => x.Id < 6).ToList();
            return res;
        }


        // GET api/<HeroiController>/5
        [HttpGet("{id}")]
        public HeroiResponse Get(int id)
        {
            return _heroiExecute.ListHerois(id);
        }

        // POST api/<HeroiController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] HeroiRequest request)
        {
            try
            {
                return Ok(await _heroiExecute.PostHeroi(request));
            }
            catch (Exception e)
            {
                return BadRequest($"erro: {e}");
            }
        }

        // PUT api/<HeroiController>/5
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] HeroiRequest request)
        {
            try
            {
                if (await _heroiExecute.UpdateHeroi(request)) 
                {
                    var LHeroi = _heroiExecute.ListHerois(request.heroi.Id).heroi;
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
