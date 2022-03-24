using System.Collections.Generic;
using System.Data;
using System.Linq;
using PCP.Domain.Entities;
using PCP.Domain.Interfaces;

namespace PCP.Infra.Repositories
{
    public class DisponibilidadeRepository : RepositoryBase<Disponibilidade_Fisica>, IDisponibilidadeRepository
    {
        public List<Disponibilidade_Fisica> GetDf()
        {
            return Db.disponibilidade_Fisicas.ToList();
        }

        public List<Disponibilidade_Fisica> GetAllDf()
        {
            return Db.Database.SqlQuery<Disponibilidade_Fisica>("select * from Disponibilidade_Fisica ").ToList();
        }
    }
}
