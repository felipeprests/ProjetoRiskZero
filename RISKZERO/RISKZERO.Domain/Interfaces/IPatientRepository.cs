using RISKZERO.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RISKZERO.Domain.Interfaces
{
    public interface IPatientRepository : IRepositoryBase<Patient>
    {
        Patient GetPatientById(int id);
        IEnumerable<Patient> GetByName(string name);
        List<Patient> GetPatients();
    }
}
