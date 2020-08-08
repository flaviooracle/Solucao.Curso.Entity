using System;
using System.Collections.Generic;
using System.Text;

namespace Solucao.Curso.Entity.Core.Models
{
    public class HeroisBatalha
    {
        public Heroi Heroi { get; set; }
        public int HeroiId { get; set; }
        public Batalha Batalha { get; set; }
        public int BatalhaId { get; set; }
    }
}
