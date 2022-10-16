using CareProWeb.Core.Entities;
using CareProWeb.Core.Interfaces;
using Dapper;
using System.Data.SqlClient;

namespace CareProWeb.Infrastructure.Repository
{
    public class PromotionsRepository : IPromotionsRepository
    {
        private readonly IConfiguration _configuration;

        public PromotionsRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public Task<bool> Add(Promotions entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Promotions>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Promotions?> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(Promotions entity)
        {
            throw new NotImplementedException();
        }
    }
}
