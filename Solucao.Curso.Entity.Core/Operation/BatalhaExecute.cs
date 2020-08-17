using Microsoft.EntityFrameworkCore;
using Solucao.Curso.Entity.Core.Operation.Interface;
using Solucao.Curso.Entity.Core.Service.Interface;
using Solucao.Curso.Entity.Dominio.DataContracts.Request;
using Solucao.Curso.Entity.Dominio.DataContracts.Response;
using Solucao.Curso.Entity.Dominio.Models;
using Solucao.Curso.Entity.Repository.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucao.Curso.Entity.Core.Operation
{
    public class BatalhaExecute : IBatalhaExecute
    {
        private readonly IEFCoreRepository _eFCoreRepository;

        public BatalhaExecute(IEFCoreRepository eFCoreRepository)
        {
            _eFCoreRepository = eFCoreRepository;
        }

        public async Task<bool> DeleteBatalha(int id)
        {
            var response = await ListBatalha(id);
            if ( response.Batalha.Id == id)
            {
                _eFCoreRepository.Delete<Batalha>(response.Batalha);
                _eFCoreRepository.SaveChangeAsync();
                return true;
            }
            return false;
        }

        public async Task<BatalhaResponse> ListBatalha(int id)
        {
            var response = new BatalhaResponse();
            response.Batalha = await _eFCoreRepository.GetBatalha(id);
            return response;    
        }

        public async Task<IEnumerable<Batalha>> ListBatalhas()
        {
            return await _eFCoreRepository.GetAllBatalhas();
        }

        public async Task<bool> PostBatalha(BatalhaRequest request)
        {
            _eFCoreRepository.Add(request.Batalha);
            return await _eFCoreRepository.SaveChangeAsync();
        }

        public async Task<bool> UpdateBatalha(BatalhaRequest request)
        {
            _eFCoreRepository.Update(request.Batalha);
            return await _eFCoreRepository.SaveChangeAsync();
        }
    }
}
