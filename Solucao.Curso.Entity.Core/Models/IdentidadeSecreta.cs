using System;
using System.Collections.Generic;
using System.Text;

namespace Solucao.Curso.Entity.Core.Models
{
    public class IdentidadeSecreta
    {
        public int Id { get; set; }
        public int NomeReal { get; set; }
        public int HeroiId { get; set; }
        public Heroi Heroi { get; set; }

    }
}
