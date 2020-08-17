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

        public async Task<bool> DeleteHeroi(int id)
        {
            var response = await ListHeroi(id);
            if (response.heroi.Id == id)
            {
                _eFCoreRepository.Delete<Heroi>(response.heroi);
                _eFCoreRepository.SaveChangeAsync();
                return true;
            }
            return false;
        }

        public async Task<List<Heroi>> ListHerois(bool incluirBatalha = true)
        {
            var res = await _eFCoreRepository.GetAllHerois(incluirBatalha);
            return res.ToList();
        }

        public async Task<HeroiResponse> ListHeroi(int id, bool incluirBatalha = true)
        {
            var response = new HeroiResponse(); 
            response.heroi = await _eFCoreRepository.GetHeroi(id, incluirBatalha);
            return response;
        }

        public async Task<bool> PostHeroi(HeroiRequest request)
        {
            _eFCoreRepository.Add(request.heroi);
            return await _eFCoreRepository.SaveChangeAsync();
        }

        public async Task<bool> UpdateHeroi(HeroiRequest request)
        {
            _eFCoreRepository.Update(request.heroi);
             return await _eFCoreRepository.SaveChangeAsync();
        }
    }
}
