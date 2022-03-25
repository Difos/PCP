using System.Collections.Generic;
using PCP.Domain.Entities;

namespace PCP.Domain.Interfaces
{
    public interface IDisponibilidadeRepository : IRepositoryBase<indisponibilidadectr>
    {
        List<indisponibilidadectr> GetDf();
    }
}
