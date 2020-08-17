using Microsoft.EntityFrameworkCore;
using Solucao.Curso.Entity.Core.Service.Interface;
using Solucao.Curso.Entity.Dominio.Models;
using Solucao.Curso.Entity.Repository.Data;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Solucao.Curso.Entity.Core.Service
{
    public class EFCoreRepository : IEFCoreRepository
    {
        private readonly HeroisContext _context;

        public EFCoreRepository(HeroisContext context)
        {
            _context = context;
        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async Task<IEnumerable<Batalha>> GetAllBatalhas()
        {
            return await _context.Batalhas.ToArrayAsync();
        }

        public async Task<Batalha> GetBatalha(int id)
        {
            return await _context.Batalhas.Where(b => b.Id == id).SingleAsync();
        }

        public async Task<Heroi[]> GetAllHerois(bool incluirBatalha = true)
        {
            IQueryable<Heroi> query = _context.Herois
                .Include(h => h.Identidade)
                .Include(h => h.Armas);

            if (incluirBatalha)
            {
                query = query.Include(h => h.HeroisBatalhas).ThenInclude(her => her.Batalha);
            }

            query = query.AsNoTracking().OrderBy(h => h.Nome);

            return await query.ToArrayAsync();
        }

        public async Task<Heroi> GetHeroi(int id, bool incluirBatalha = true)
        {
            IQueryable<Heroi> query = _context.Herois
                .Include(h => h.Identidade)
                .Include(h => h.Armas);

            if (incluirBatalha)
            {
                query = query.Include(h => h.HeroisBatalhas).ThenInclude(her => her.Batalha);
            }

            query = query.Where(w => w.Id == id); 
            query = query.AsNoTracking().OrderBy(h => h.Nome);

            return await query.SingleOrDefaultAsync();
        }

        public async Task<bool> SaveChangeAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }


    }
}
