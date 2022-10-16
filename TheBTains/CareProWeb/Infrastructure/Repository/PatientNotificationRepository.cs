using CareProWeb.Core.Entities;
using CareProWeb.Core.Interfaces;
using Dapper;
using System.Data.SqlClient;

namespace CareProWeb.Infrastructure.Repository
{
    public class PatientNotificationRepository : IPatientNotificationRepository
    {
        private readonly IConfiguration _configuration;

        public PatientNotificationRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public Task<bool> Add(PatientNotification entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PatientNotification>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<PatientNotification?> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(PatientNotification entity)
        {
            throw new NotImplementedException();
        }
    }
}
