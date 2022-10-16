using CareProWeb.Core.Entities;
using CareProWeb.Core.Interfaces;
using Dapper;
using System.Data.SqlClient;

namespace CareProWeb.Infrastructure.Repository
{
    public class CheckupScheduleRepository : ICheckupScheduleRepository
    {
        private readonly IConfiguration _configuration;

        public CheckupScheduleRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<bool> Add(CheckupSchedule entity)
        {
            var sql = "INSERT INTO [dbo].[patient] (id,name,nic) VALUES (@id,@name,@nic)";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.ExecuteAsync(sql, entity);
                return true;
            }

        }

        public async Task<IEnumerable<Doctor>> GetAll()
        {
            var sql = "SELECT * FROM Product";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.QueryAsync<Doctor>(sql);
                return result.ToList();
            }
        }

        public async Task<Doctor?> GetById(int id)
        {
            var sql = "SELECT * FROM Product WHERE Id = @Id";
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.QuerySingleOrDefaultAsync<Doctor>(sql, new { Id = id });
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

        public async Task<bool> Update(CheckupSchedule entity)
        {
            var sql = "UPDATE Product SET Sku = @Sku, Name = @Name, Manufacturer = @Manufacturer, Price = @Price WHERE Id = @Id";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                await connection.ExecuteAsync(sql, entity);
                return true;
            }
        }

        Task<IEnumerable<CheckupSchedule>> IGenericRepository<CheckupSchedule>.GetAll()
        {
            throw new NotImplementedException();
        }

        Task<CheckupSchedule?> IGenericRepository<CheckupSchedule>.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
