
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Solucao.Curso.Entity.Core.Operation.Interface;
using Solucao.Curso.Entity.Dominio.DataContracts.Request;
using Solucao.Curso.Entity.Dominio.DataContracts.Response;
using Solucao.Curso.Entity.Dominio.Models;
using Solucao.Curso.Entity.Repository.Data;
using System;
using System.Collections.Generic;
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

        public IEnumerable<HeroiResponse> ListHerois()
        {
            throw new NotImplementedException();
        }

        public HeroiResponse PostHeroi(HeroiRequest request)
        {
            try
            {
                var response = new HeroiResponse()
                {
                    heroi = new Heroi()
                    {
                        Nome = request.heroi.Nome,
                        Armas = new List<Arma>()
                        {
                            new Arma{Nome = request.heroi.Armas[0].Nome},
                            new Arma{Nome = request.heroi.Armas[1].Nome}
                        }
                    }
                };

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
            try
            {
                var response = new HeroiResponse()
                {
                    heroi = new Heroi()
                    {
                        Nome = request.heroi.Nome,
                        Id = request.heroi.Id,
                        Armas = new List<Arma>()
                        {
                            new Arma{Id = request.heroi.Armas[0].Id, Nome = request.heroi.Armas[0].Nome},
                            new Arma{Id = request.heroi.Armas[1].Id, Nome = request.heroi.Armas[1].Nome}
                        }
                    }
                };

                _context.Herois.Update(response.heroi);
                _context.SaveChanges();

                return response;
            }
            catch (Exception e)
            {
                return null;
            }

        }
    }
}
