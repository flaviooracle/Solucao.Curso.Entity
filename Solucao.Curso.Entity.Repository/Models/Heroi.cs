
using System.Collections.Generic;

namespace Solucao.Curso.Entity.Repository.Models
{
    public class Heroi
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public IdentidadeSecreta Identidade { get; set; }
        public List<Arma> Armas { get; set; }
        public List<HeroisBatalha> HeroisBatalhas { get; set; }

    }
}