using CareProWeb.Core.Entities;
using CareProWeb.Core.Interfaces;
using Dapper;
using System.Data.SqlClient;

namespace CareProWeb.Infrastructure.Repository
{
    public class DoctorsPrescriptionRepository : IDoctorsPrescriptionRepository
    {
        private readonly IConfiguration _configuration;

        public DoctorsPrescriptionRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public Task<bool> Add(DoctorsPrescription entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<DoctorsPrescription>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<DoctorsPrescription?> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(DoctorsPrescription entity)
        {
            throw new NotImplementedException();
        }
    }
}
