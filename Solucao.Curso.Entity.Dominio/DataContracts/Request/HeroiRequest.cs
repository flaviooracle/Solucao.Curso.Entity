﻿using Solucao.Curso.Entity.Dominio.DataContracts.Interfaces;
using Solucao.Curso.Entity.Dominio.Models;

namespace Solucao.Curso.Entity.Dominio.DataContracts.Request
{
    public class HeroiRequest: IHeroi
    {
        public Heroi heroi { get; set; }
    }
}
