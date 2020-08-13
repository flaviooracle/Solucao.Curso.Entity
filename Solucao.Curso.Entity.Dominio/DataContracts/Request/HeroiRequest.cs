using Solucao.Curso.Entity.Dominio.DataContracts.Interfaces;
using Solucao.Curso.Entity.Dominio.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace Solucao.Curso.Entity.Dominio.DataContracts.Request
{
    public class HeroiRequest: IHeroi
    {
        public Heroi heroi { get; set; }
    }
}
