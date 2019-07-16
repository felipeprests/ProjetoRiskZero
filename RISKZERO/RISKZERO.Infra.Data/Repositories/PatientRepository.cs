using RISKZERO.Domain.Entities;
using RISKZERO.Domain.Interfaces;
using RISKZERO.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RISKZERO.Infra.Data.Repositories
{
    public class PatientRepository : RepositoryBase<Patient>, IPatientRepository
    {
        public IEnumerable<Patient> GetByName(string name)
        {
            using (var ctx = new RiskzeroContext())
            {
                return ctx.Patients.Where(p => p.FullName == name);
            }
        }

        public Patient GetPatientById(int id)
        {
            using (var ctx = new RiskzeroContext())
            {
                return ctx.Patients.Find(id);
            }
        }

        public IEnumerable<Patient> GetByBirthDate(DateTime birthDate)
        {
            using (var ctx = new RiskzeroContext())
            {
                return ctx.Patients.Where(x => x.BirthDate == birthDate);
            }
        }
    }
}
