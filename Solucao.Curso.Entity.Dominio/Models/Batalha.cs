﻿using System.Collections.Generic;

namespace Solucao.Curso.Entity.Dominio.Models
{
    public class Batalha
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<HeroisBatalha> HeroisBatalhas { get; set; }
    }
}
