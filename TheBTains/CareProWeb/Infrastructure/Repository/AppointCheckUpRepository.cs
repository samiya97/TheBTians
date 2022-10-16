using CareProWeb.Core.Entities;
using CareProWeb.Core.Interfaces;
using Dapper;
using System.Data.SqlClient;

namespace CareProWeb.Infrastructure.Repository
{
    public class AppointCheckUpRepository : IAppointCheckUpRepository
    {
        private readonly IConfiguration _configuration;

        public AppointCheckUpRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public Task<bool> Add(AppointCheckUp entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AppointCheckUp>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<AppointCheckUp?> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(AppointCheckUp entity)
        {
            throw new NotImplementedException();
        }
    }
}
