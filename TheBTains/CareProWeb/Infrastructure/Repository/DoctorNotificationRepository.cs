using CareProWeb.Core.Entities;
using CareProWeb.Core.Interfaces;
using Dapper;
using System.Data.SqlClient;

namespace CareProWeb.Infrastructure.Repository
{
    public class DoctorNotificationRepository : IDoctorNotificationRepository
    {
        private readonly IConfiguration _configuration;

        public DoctorNotificationRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public Task<bool> Add(DoctorNotification entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<DoctorNotification>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<DoctorNotification?> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(DoctorNotification entity)
        {
            throw new NotImplementedException();
        }
    }
}
