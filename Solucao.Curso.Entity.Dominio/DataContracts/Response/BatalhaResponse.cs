using Solucao.Curso.Entity.Dominio.DataContracts.Interfaces;
using Solucao.Curso.Entity.Dominio.Models;

namespace Solucao.Curso.Entity.Dominio.DataContracts.Response
{
    public class BatalhaResponse: IBatalha
    {
        public Batalha batalha { get; set; }
    }
}
