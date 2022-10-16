using CareProWeb.Core.Entities;
using CareProWeb.Core.Interfaces;
using Dapper;
using System.Data.SqlClient;

namespace CareProWeb.Infrastructure.Repository
{
    public class DoctorReviewsRepository : IDoctorReviewsRepository
    {
        private readonly IConfiguration _configuration;

        public DoctorReviewsRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public Task<bool> Add(DoctorReviews entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<DoctorReviews>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<DoctorReviews?> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(DoctorReviews entity)
        {
            throw new NotImplementedException();
        }
    }
}
