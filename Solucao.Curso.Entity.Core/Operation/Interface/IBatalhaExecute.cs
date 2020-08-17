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
        Task<IEnumerable<Batalha>> ListBatalhas();
        Task<BatalhaResponse> ListBatalha(int id);
        Task<bool> PostBatalha(BatalhaRequest request);
        Task<bool> DeleteBatalha(int id);
        Task<bool> UpdateBatalha(BatalhaRequest request);
    }
}
