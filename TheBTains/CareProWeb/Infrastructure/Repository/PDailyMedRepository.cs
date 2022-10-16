using CareProWeb.Core.Entities;
using CareProWeb.Core.Interfaces;
using Dapper;
using System.Data.SqlClient;

namespace CareProWeb.Infrastructure.Repository
{
    public class PDailyMedRepository : IPDailyMedRepository
    {
        private readonly IConfiguration _configuration;

        public PDailyMedRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public Task<bool> Add(PDailyMed entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PDailyMed>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<PDailyMed?> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(PDailyMed entity)
        {
            throw new NotImplementedException();
        }
    }
}
