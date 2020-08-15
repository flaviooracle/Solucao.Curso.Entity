using Solucao.Curso.Entity.Core.Operation.Interface;
using Solucao.Curso.Entity.Core.Service.Interface;
using Solucao.Curso.Entity.Dominio.DataContracts.Request;
using Solucao.Curso.Entity.Dominio.DataContracts.Response;
using Solucao.Curso.Entity.Dominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solucao.Curso.Entity.Core.Operation
{
    public class HeroiExecute: IHeroiExecute
    {
        private readonly IEFCoreRepository _eFCoreRepository;

        public HeroiExecute(IEFCoreRepository eFCoreRepository)
        {
            _eFCoreRepository = eFCoreRepository;       
        }

        public HeroiResponse DeleteHeroi(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Heroi>> ListHerois()
        {
            var res = await _eFCoreRepository.GetAllHerois();
            return res.ToList();
        }

        public HeroiResponse ListHerois(int id)
        {
            var response = new HeroiResponse(); 
          //  response.heroi = _eFCoreRepository.Herois.Find(id);
            return response;
        }

        public async Task<bool> PostHeroi(HeroiRequest request)
        {
            _eFCoreRepository.Add(request.heroi);
            return await _eFCoreRepository.SaveChangeAsync();
        }

        public async Task<bool> UpdateHeroi(HeroiRequest request)
        {
            //this.eFCoreRepository.Herois.AsNoTracking().FirstOrDefault(h => h.Id == request.heroi.Id) != null)
            _eFCoreRepository.Update(request.heroi);
             return await _eFCoreRepository.SaveChangeAsync();

        }
    }
}
