
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
using System.Threading.Tasks;

namespace Solucao.Curso.Entity.Core.Operation
{
    public class HeroiExecute: IHeroiExecute
    {
        private readonly HeroisContext _context;
        public HeroiExecute(HeroisContext context)
        {
            _context = context;
        }

        public HeroiResponse DeleteHeroi(int id)
        {
            throw new NotImplementedException();
        }

        public HeroiResponse GetHeroi(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Heroi> ListHerois()
        {
            return _context.Herois.ToList();
        }

        public HeroiResponse ListHerois(int id)
        {
            var response = new HeroiResponse(); 
            response.heroi = _context.Herois.Find(id);
            return response;
            
        }

        public HeroiResponse PostHeroi(HeroiRequest request)
        {
            try
            {
                var response = new HeroiResponse();
                response.heroi = request.heroi;

                _context.Herois.Add(response.heroi);
                _context.SaveChanges();

                return response;
            }
            catch(Exception e)
            {
                return null;
            }

        }

        public HeroiResponse UpdateHeroi(HeroiRequest request)
        {
            var response = new HeroiResponse();
            try
            {
                if (_context.Herois.AsNoTracking().FirstOrDefault(h => h.Id == request.heroi.Id) != null)
                {
                    _context.Herois.Update(request.heroi);
                    _context.SaveChanges();
                    response.heroi = request.heroi;
                }
            }
            catch (Exception e)
            {
            
            }
            return response;
        }
    }
}
