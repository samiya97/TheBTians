using CareProWeb.Core.Entities;
using CareProWeb.Core.Interfaces;
using Dapper;
using System.Data.SqlClient;

namespace CareProWeb.Infrastructure.Repository
{
    public class HospitalsRepository : IHospitalsRepository
    {
        private readonly IConfiguration _configuration;

        public HospitalsRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public Task<bool> Add(Hospitals entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Hospitals>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Hospitals?> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(Hospitals entity)
        {
            throw new NotImplementedException();
        }
    }
}
