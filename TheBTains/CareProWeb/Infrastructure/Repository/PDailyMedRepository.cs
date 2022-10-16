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

        public async Task<IEnumerable<PDailyMed>> GetAll()
        {
            var sql = "SELECT * FROM PDailyMed";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.QueryAsync<PDailyMed>(sql);
                return result.ToList();
            }
        }

        public Task<PDailyMed?> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Remove(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Update(PDailyMed entity)
        {
            var sql = "UPDATE PDailyMed SET MedTaken = @MedTaken";
using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                await connection.ExecuteAsync(sql, entity);
                return true;
            }
        }
    }
}
