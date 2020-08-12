

namespace Solucao.Curso.Entity.Dominio.Models
{
    public class HeroisBatalha
    {
        public Heroi Heroi { get; set; }
        public int HeroiId { get; set; }
        public Batalha Batalha { get; set; }
        public int BatalhaId { get; set; }
    }
}
