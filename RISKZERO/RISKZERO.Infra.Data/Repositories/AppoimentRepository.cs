using RISKZERO.Domain.Entities;
using RISKZERO.Domain.Interfaces;
using RISKZERO.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace RISKZERO.Infra.Data.Repositories
{
    public class AppoimentRepository : RepositoryBase<Appoiment>, IAppoimentRepository
    {
        public Appoiment GetAppoimentById(int id)
        {
            using (var ctx = new RiskzeroContext())
            {
                return ctx.Appoiments.Find(id);
            }
        }
    }
}
