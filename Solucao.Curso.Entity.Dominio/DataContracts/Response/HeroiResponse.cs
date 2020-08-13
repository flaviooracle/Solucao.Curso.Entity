using Solucao.Curso.Entity.Dominio.DataContracts.Interfaces;
using Solucao.Curso.Entity.Dominio.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solucao.Curso.Entity.Dominio.DataContracts.Response
{
    public class HeroiResponse: IHeroi
    {
        public Heroi heroi { get; set; }
    }
}
