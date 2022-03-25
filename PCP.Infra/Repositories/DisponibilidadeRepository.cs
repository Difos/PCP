using System.Collections.Generic;
using System.Data;
using System.Linq;
using PCP.Domain.Entities;
using PCP.Domain.Interfaces;

namespace PCP.Infra.Repositories
{
    public class DisponibilidadeRepository : RepositoryBase<indisponibilidadectr>, IDisponibilidadeRepository
    {
        public List<indisponibilidadectr> GetDf()
        {
            return Db.disponibilidade_Fisicas.ToList();
        }

        public List<indisponibilidadectr> GetAllDf()
        {
            // return Db.Database.SqlQuery<indisponibilidadectr>(@"select * from indisponibilidadectr").ToList();
           
                return Db.Database.SqlQuery<indisponibilidadectr>(@"select x as Id, df as Idf, meta as Meta, ac as Acum from disponibilidade_fisica2017").ToList();
        }
    }
}
