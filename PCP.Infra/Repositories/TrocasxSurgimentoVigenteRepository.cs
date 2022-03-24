using PCP.Domain.Entities;
using PCP.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCP.Infra.Repositories
{
    public class TrocasxSurgimentoVigenteRepository : RepositoryBase<TrocasxSurgimentoVigente>, ITrocasxSurgimentoVigenteRepository
    {
        public List<TrocasxSurgimentoVigente> GetTrocas()
        {
            return Db.Database.SqlQuery<TrocasxSurgimentoVigente>("select * from TrocasxSurgimentoVigente").ToList();
        }
    }
}
