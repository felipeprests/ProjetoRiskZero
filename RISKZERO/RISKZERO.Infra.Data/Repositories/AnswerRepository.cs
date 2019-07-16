using RISKZERO.Domain.Entities;
using RISKZERO.Domain.Interfaces;
using RISKZERO.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace RISKZERO.Infra.Data.Repositories
{
    public class AnswerRepository : RepositoryBase<Answer>, IAnswerRepository
    {
        public Answer GetAnswerById(int id)
        {
            using (var ctx = new RiskzeroContext())
            {
                return ctx.Answers.Find(id);
            }
        }
    }
}
