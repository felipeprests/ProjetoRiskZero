using RISKZERO.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RISKZERO.Domain.Interfaces
{
    public interface IAppoimentRepository : IRepositoryBase<Appoiment>
    {
        Appoiment GetAppoimentById(int id);
    }
}
