using CareProWeb.Core.Entities;
using CareProWeb.Core.Interfaces;
using Dapper;
using System.Data.SqlClient;

namespace CareProWeb.Infrastructure.Repository
{
    public class PLabTestAppointmentRepository : IPLabTestAppointmentRepository
    {
        private readonly IConfiguration _configuration;

        public PLabTestAppointmentRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public Task<bool> Add(PLabTestAppointment entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PLabTestAppointment>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<PLabTestAppointment?> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(PLabTestAppointment entity)
        {
            throw new NotImplementedException();
        }
    }
}
