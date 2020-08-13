using Microsoft.AspNetCore.Mvc;
using Solucao.Curso.Entity.Dominio.DataContracts.Request;
using Solucao.Curso.Entity.Dominio.DataContracts.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solucao.Curso.Entity.Core.Operation.Interface
{
    public interface IHeroiExecute
    {
        IEnumerable<HeroiResponse> ListHerois();
        HeroiResponse GetHeroi(int id);
        HeroiResponse PostHeroi(HeroiRequest request);
        HeroiResponse DeleteHeroi(int id);
        HeroiResponse UpdateHeroi(HeroiRequest request);

    }
}
