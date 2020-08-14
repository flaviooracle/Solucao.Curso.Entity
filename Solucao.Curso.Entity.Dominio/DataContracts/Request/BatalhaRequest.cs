using Solucao.Curso.Entity.Dominio.DataContracts.Interfaces;
using Solucao.Curso.Entity.Dominio.Models;

namespace Solucao.Curso.Entity.Dominio.DataContracts.Request
{
    public class BatalhaRequest: IBatalha
    {
        public Batalha batalha { get; set; }
    }
}
