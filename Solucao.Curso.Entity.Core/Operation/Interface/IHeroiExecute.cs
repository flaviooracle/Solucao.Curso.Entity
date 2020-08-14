using Microsoft.AspNetCore.Mvc;
using Solucao.Curso.Entity.Dominio.DataContracts.Request;
using Solucao.Curso.Entity.Dominio.DataContracts.Response;
using Solucao.Curso.Entity.Dominio.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solucao.Curso.Entity.Core.Operation.Interface
{
    public interface IHeroiExecute
    {
        IEnumerable<Heroi> ListHerois();
        HeroiResponse ListHerois(int id);
        HeroiResponse GetHeroi(int id);
        HeroiResponse PostHeroi(HeroiRequest request);
        HeroiResponse DeleteHeroi(int id);
        HeroiResponse UpdateHeroi(HeroiRequest request);

    }
}
