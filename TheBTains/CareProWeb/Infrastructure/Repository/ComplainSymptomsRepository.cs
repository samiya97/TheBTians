using CareProWeb.Core.Entities;
using CareProWeb.Core.Interfaces;
using Dapper;
using System.Data.SqlClient;

namespace CareProWeb.Infrastructure.Repository
{
    public class ComplainSymptomsRepository : IComplainSymptomsRepository
    {
        private readonly IConfiguration _configuration;

        public ComplainSymptomsRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<bool> Add(ComplainSymptoms entity)
        {
            var sql = "INSERT INTO [dbo].[Product] ([Sku], [Name], [Manufacturer],[Price]) VALUES (@Sku, @Name, @Manufacturer, @Price)";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.ExecuteAsync(sql, entity);
                return true;
            }

        }

        public async Task<IEnumerable<ComplainSymptoms>> GetAll()
        {
            var sql = "SELECT * FROM Product";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.QueryAsync<ComplainSymptoms>(sql);
                return result.ToList();
            }
        }

        public async Task<ComplainSymptoms?> GetById(int id)
        {
            var sql = "SELECT * FROM Product WHERE Id = @Id";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.QuerySingleOrDefaultAsync<ComplainSymptoms>(sql, new { Id = id });
                return result;
            }
        }

        public async Task<bool> Remove(int id)
        {
            var sql = "DELETE FROM Products WHERE Id = @Id";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.ExecuteAsync(sql, new { Id = id });
                return true;
            }
        }

        public async Task<bool> Update(ComplainSymptoms entity)
        {
            var sql = "UPDATE Product SET Sku = @Sku, Name = @Name, Manufacturer = @Manufacturer, Price = @Price WHERE Id = @Id";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                await connection.ExecuteAsync(sql, entity);
                return true;
            }
        }
    }
}
