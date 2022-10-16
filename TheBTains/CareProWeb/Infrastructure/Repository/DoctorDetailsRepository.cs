using CareProWeb.Core.Entities;
using CareProWeb.Core.Interfaces;
using Dapper;
using System.Data.SqlClient;

namespace CareProWeb.Infrastructure.Repository
{
    public class DoctorDetailsRepository : IDoctorDetailsRepository
    {
        private readonly IConfiguration _configuration;

        public DoctorDetailsRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public Task<bool> Add(DoctorDetails entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<DoctorDetails>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<DoctorDetails?> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(DoctorDetails entity)
        {
            throw new NotImplementedException();
        }
    }
}
