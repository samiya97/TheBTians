using CareProWeb.Core.Entities;
using CareProWeb.Core.Interfaces;
using Dapper;
using System.Data.SqlClient;

namespace CareProWeb.Infrastructure.Repository
{
    public class SignUpRepository : ISignUpRepository
    {
        private readonly IConfiguration _configuration;

        public SignUpRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public Task<bool> Add(SignUp entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<SignUp>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<SignUp?> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(SignUp entity)
        {
            throw new NotImplementedException();
        }
    }
}
