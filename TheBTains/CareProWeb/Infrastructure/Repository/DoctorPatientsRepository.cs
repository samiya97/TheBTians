using CareProWeb.Core.Entities;
using CareProWeb.Core.Interfaces;
using Dapper;
using System.Data.SqlClient;

namespace CareProWeb.Infrastructure.Repository
{
    public class DoctorPatientsRepository : IDoctorPatientsRepository
    {
        private readonly IConfiguration _configuration;

        public DoctorPatientsRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public Task<bool> Add(DoctorPatients entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<DoctorPatients>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<DoctorPatients?> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(DoctorPatients entity)
        {
            throw new NotImplementedException();
        }
    }
}
