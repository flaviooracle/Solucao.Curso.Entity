using Solucao.Curso.Entity.Dominio.DataContracts.Request;
using Solucao.Curso.Entity.Dominio.DataContracts.Response;
using Solucao.Curso.Entity.Dominio.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Solucao.Curso.Entity.Core.Operation.Interface
{
    public interface IBatalhaExecute
    {
        IEnumerable<Batalha> ListBatalhas();
        BatalhaResponse ListBatalha(int id);
        Task<bool> PostBatalha(BatalhaRequest request);
        BatalhaResponse DeleteBatalha(int id);
        BatalhaResponse UpdateBatalha(BatalhaRequest request);
    }
}
