using RISKZERO.Domain.Entities;
using RISKZERO.Domain.Interfaces;
using RISKZERO.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RISKZERO.Infra.Data.Repositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public User GetUserById(int id)
        {
            using (var ctx = new RiskzeroContext())
            {
                return ctx.Users.Find(id);
            }
        }

        public IEnumerable<User> GetUserByName(string name)
        {
            using (var ctx = new RiskzeroContext())
            {
                return ctx.Users.Where(x => x.FullName == name);
            }
        }
    }
}
