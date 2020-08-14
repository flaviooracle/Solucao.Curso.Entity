using Microsoft.AspNetCore.Mvc;
using Solucao.Curso.Entity.Core.Operation.Interface;
using Solucao.Curso.Entity.Dominio.DataContracts.Request;
using Solucao.Curso.Entity.Dominio.Models;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Solucao.Curso.Entity.WebApi.Controllers
{
    [Route("api/batalha")]
    [ApiController]
    public class BatalhaController : ControllerBase
    {
        private readonly IBatalhaExecute _batalhaExecute;
        public BatalhaController(IBatalhaExecute batalhaExecute)
        {
            _batalhaExecute = batalhaExecute;
        }

        // GET: api/<BatalhaController>
        [HttpGet]
        public IEnumerable<Batalha> Get()
        {
            return _batalhaExecute.ListBatalhas();
        }

        // GET api/<BatalhaController>/5
        [HttpGet("{id}")]
        public Batalha Get(int id)
        {
            return _batalhaExecute.ListBatalha(id).batalha;
        }

        // POST api/<BatalhaController>
        [HttpPost]
        public IActionResult Post([FromBody] BatalhaRequest request)
        {
            var response = _batalhaExecute.PostBatalha(request);
            return Ok("Gravado");
        }

        // PUT api/<BatalhaController>/5
        [HttpPut]
        public IActionResult Put([FromBody] BatalhaRequest request)
        {
            var response = _batalhaExecute.UpdateBatalha(request);
            
            if (response != null)
            {
                var LBatalha = _batalhaExecute.ListBatalha(response.batalha.Id).batalha;
                return Ok("A Batalha: " + LBatalha.Nome + " foi atualizado  !!!!");
            }
            return Ok("Erro ao atualizar");
        }

        // DELETE api/<BatalhaController>/5
        [HttpDelete]
        public void Delete(int id)
        {
        }
    }
}
