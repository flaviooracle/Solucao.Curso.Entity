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

        public BatalhaResponse DeleteBatalha(int id)
        {
            throw new NotImplementedException();
        }

        public BatalhaResponse ListBatalha(int id)
        {
            var response = new BatalhaResponse()
            {
              //  batalha = _eFCoreRepository.Find(id)
            };
            return response;    
        }

        public IEnumerable<Batalha> ListBatalhas()
        {
            return new List<Batalha>(); // _eFCoreRepository.Batalhas.ToList();
        }

        public async Task<bool> PostBatalha(BatalhaRequest request)
        {
            _eFCoreRepository.Add(request.batalha);
            return await _eFCoreRepository.SaveChangeAsync();
        }

        public BatalhaResponse UpdateBatalha(BatalhaRequest request)
        {
            var response = new BatalhaResponse();
            

            //if (_eFCoreRepository.Batalhas.AsNoTracking().FirstOrDefault(h => h.Id == request.batalha.Id) != null)
            //{
            //    _eFCoreRepository.Batalhas.Update(request.batalha);
            //    _eFCoreRepository.SaveChanges();
            //    response.batalha = request.batalha;
            //}
           
            return response;
            
        }
    }
}
