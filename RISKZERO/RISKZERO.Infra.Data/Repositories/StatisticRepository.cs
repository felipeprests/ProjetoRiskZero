using RISKZERO.Domain.Entities;
using RISKZERO.Domain.Interfaces;
using RISKZERO.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace RISKZERO.Infra.Data.Repositories
{
    public class StatisticRepository : RepositoryBase<Statistic>, IStatisticRepository
    {
        public Statistic GetStatisticById(int id)
        {
            using (var ctx = new RiskzeroContext())
            {
                return ctx.Statistics.Find(id);
            }
        }
    }
}
