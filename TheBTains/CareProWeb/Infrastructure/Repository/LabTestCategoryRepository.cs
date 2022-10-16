using CareProWeb.Core.Entities;
using CareProWeb.Core.Interfaces;
using Dapper;
using System.Data.SqlClient;

namespace CareProWeb.Infrastructure.Repository
{
    public class LabTestCategoryRepository : ILabTestCategoryRepository
    {
        private readonly IConfiguration _configuration;

        public LabTestCategoryRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public Task<bool> Add(LabTestCategory entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<LabTestCategory>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<LabTestCategory?> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(LabTestCategory entity)
        {
            throw new NotImplementedException();
        }
    }
}
