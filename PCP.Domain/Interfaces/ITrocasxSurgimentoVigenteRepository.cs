using PCP.Domain.Entities;
using System.Collections.Generic;

namespace PCP.Domain.Interfaces
{
    public interface ITrocasxSurgimentoVigenteRepository : IRepositoryBase<TrocasxSurgimentoVigente>
    {
        List<TrocasxSurgimentoVigente> GetTrocas();
    }
}
