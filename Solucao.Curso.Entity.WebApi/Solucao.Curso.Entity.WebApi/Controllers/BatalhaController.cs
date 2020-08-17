using Microsoft.AspNetCore.Mvc;
using Solucao.Curso.Entity.Core.Operation.Interface;
using Solucao.Curso.Entity.Dominio.DataContracts.Request;
using Solucao.Curso.Entity.Dominio.DataContracts.Response;
using Solucao.Curso.Entity.Dominio.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

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
        public async Task<IEnumerable<Batalha>> GetBatalhas()
        {
            return await _batalhaExecute.ListBatalhas();
        }

        // GET api/<BatalhaController>/5
        [HttpGet("{id}")]
        public async Task<BatalhaResponse> GetBatalha(int id)
        {
            return await _batalhaExecute.ListBatalha(id);
        }

        // POST api/<BatalhaController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] BatalhaRequest request)
        {
            if (await _batalhaExecute.PostBatalha(request))
            {
                return Ok("Gravado");
            }
            return Ok("Problema Gravação");
        }

        // PUT api/<BatalhaController>/5
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] BatalhaRequest request)
        {            
            if (await _batalhaExecute.UpdateBatalha(request))
            {
                var LBatalha = await _batalhaExecute.ListBatalha(request.Batalha.Id);
                return Ok("A Batalha: " + LBatalha.Batalha.Nome + " foi atualizado  !!!!");
            }
            return Ok("Erro ao atualizar");
        }

        // DELETE api/<BatalhaController>/5
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            if (await _batalhaExecute.DeleteBatalha(id))
            {   
                return Ok("A Batalha Excluida com Sucesso !!");
            }
            return Ok("Erro ao tentar excluir batalha");
        }
    }
}
