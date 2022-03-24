using System.Collections.Generic;
using PCP.Domain.Entities;

namespace PCP.Domain.Interfaces
{
    public interface IDisponibilidadeRepository : IRepositoryBase<Disponibilidade_Fisica>
    {
        List<Disponibilidade_Fisica> GetDf();
    }
}
