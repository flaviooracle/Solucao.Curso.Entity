using Solucao.Curso.Entity.Dominio.DataContracts.Request;
using Solucao.Curso.Entity.Dominio.DataContracts.Response;
using Solucao.Curso.Entity.Dominio.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Solucao.Curso.Entity.Core.Operation.Interface
{
    public interface IHeroiExecute
    {
        Task<List<Heroi>> ListHerois();
        HeroiResponse ListHerois(int id);
        Task<bool> PostHeroi(HeroiRequest request);
        HeroiResponse DeleteHeroi(int id);
        Task<bool> UpdateHeroi(HeroiRequest request);

    }
}
