using CareProWeb.Core.Entities;
using CareProWeb.Core.Interfaces;

namespace CareProWeb.Infrastructure.Repository
{
    public class PatientRepository : IPatientRepository
    {
        public Task<bool> Add(Patient entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Patient>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Patient?> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(Patient entity)
        {
            throw new NotImplementedException();
        }
    }
}
