using System.Data;

namespace Data_Access_Layer
{
    public interface IDNTConnectionFactory
    {
        public IDbConnection GetConnection { get; }
        public void CloseConnection();
    }
}