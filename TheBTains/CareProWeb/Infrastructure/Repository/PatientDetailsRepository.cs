using CareProWeb.Core.Entities;
using CareProWeb.Core.Interfaces;
using Dapper;
using System.Data.SqlClient;

namespace CareProWeb.Infrastructure.Repository
{
    public class PatientDetailsRepository : IPatientDetailsRepository
    {
        private readonly IConfiguration _configuration;

        public PatientDetailsRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public Task<bool> Add(PatientDetails entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PatientDetails>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<PatientDetails?> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(PatientDetails entity)
        {
            throw new NotImplementedException();
        }
    }
}
