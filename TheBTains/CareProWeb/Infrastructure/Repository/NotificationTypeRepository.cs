using CareProWeb.Core.Entities;
using CareProWeb.Core.Interfaces;
using Dapper;
using System.Data.SqlClient;

namespace CareProWeb.Infrastructure.Repository
{
    public class NotificationTypeRepository : INotificationTypeRepository
    {
        private readonly IConfiguration _configuration;

        public NotificationTypeRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public Task<bool> Add(NotificationType entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<NotificationType>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<NotificationType?> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(NotificationType entity)
        {
            throw new NotImplementedException();
        }
    }
}
