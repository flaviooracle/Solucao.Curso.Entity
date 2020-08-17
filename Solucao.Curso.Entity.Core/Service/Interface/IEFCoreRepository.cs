using Solucao.Curso.Entity.Dominio.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Solucao.Curso.Entity.Core.Service.Interface
{
    public interface IEFCoreRepository
    {
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveChangeAsync();

        Task<Heroi[]> GetAllHerois(bool incluirBatalha);
        Task<Heroi> GetHeroi(int id, bool incluirBatalha);
        Task<IEnumerable<Batalha>> GetAllBatalhas();
        Task<Batalha> GetBatalha(int id);

    }
}
