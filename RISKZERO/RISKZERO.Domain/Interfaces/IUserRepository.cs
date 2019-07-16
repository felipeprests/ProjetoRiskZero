using RISKZERO.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RISKZERO.Domain.Interfaces
{
    public interface IUserRepository : IRepositoryBase<User>
    {
        User GetUserById(int id);
        IEnumerable<User> GetUserByName(string name);
    }
}
