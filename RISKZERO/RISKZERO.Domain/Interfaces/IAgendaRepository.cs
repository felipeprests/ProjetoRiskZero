using RISKZERO.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RISKZERO.Domain.Interfaces
{
    public interface IAgendaRepository : IRepositoryBase<Agenda>
    {
        Agenda GetAgendaById(int id);
    }
}
