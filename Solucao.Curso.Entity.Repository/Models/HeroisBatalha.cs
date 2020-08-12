

namespace Solucao.Curso.Entity.Repository.Models
{
    public class HeroisBatalha
    {
        public Heroi Heroi { get; set; }
        public int HeroiId { get; set; }
        public Batalha Batalha { get; set; }
        public int BatalhaId { get; set; }
    }
}
