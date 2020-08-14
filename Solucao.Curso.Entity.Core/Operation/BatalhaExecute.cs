using Microsoft.EntityFrameworkCore;
using Solucao.Curso.Entity.Core.Operation.Interface;
using Solucao.Curso.Entity.Dominio.DataContracts.Request;
using Solucao.Curso.Entity.Dominio.DataContracts.Response;
using Solucao.Curso.Entity.Dominio.Models;
using Solucao.Curso.Entity.Repository.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solucao.Curso.Entity.Core.Operation
{
    public class BatalhaExecute : IBatalhaExecute
    {
        private readonly HeroisContext _context;
        public BatalhaExecute(HeroisContext context)
        {
            _context = context;
        }

        public BatalhaResponse DeleteBatalha(int id)
        {
            throw new NotImplementedException();
        }

        public BatalhaResponse ListBatalha(int id)
        {
            var response = new BatalhaResponse()
            {
                batalha = _context.Batalhas.Find(id)
            };
            return response;    
        }

        public IEnumerable<Batalha> ListBatalhas()
        {
            return _context.Batalhas.ToList();
        }

        public BatalhaResponse PostBatalha(BatalhaRequest request)
        {
            var response = new BatalhaResponse();
            response.batalha = request.batalha;

            _context.Batalhas.Add(request.batalha);
            _context.SaveChanges();

            return response;
        }

        public BatalhaResponse UpdateBatalha(BatalhaRequest request)
        {
            var response = new BatalhaResponse();
            

            if (_context.Batalhas.AsNoTracking().FirstOrDefault(h => h.Id == request.batalha.Id) != null)
            {
                _context.Batalhas.Update(request.batalha);
                _context.SaveChanges();
                response.batalha = request.batalha;
            }
           
            return response;
            
        }
    }
}
