using Dapper;
using Microsoft.Extensions.Configuration;
using Phoenix.Core.Models.Configuration;
using System.Data.SqlClient;

namespace Phoenix.Core.Infrastructure
{
    public class PhoenixSqlConnection : IDisposable
    {
        private readonly SqlConnection connection;

        private readonly IConfiguration configuration;

        private string ConnectionString
        {
            get
            {
                return configuration.GetConnectionString(nameof(ConnectionStrings.PhoenixDb));
            }
        }

        public PhoenixSqlConnection(IConfiguration configuration)
        {
            this.configuration = configuration;

            connection = new SqlConnection(ConnectionString);
            connection.Open();
        }

        public IEnumerable<T> Query<T>(string sql, object? param)
        {
            return connection.Query<T>(sql, param);
        }

        public IEnumerable<T> Query<T>(string sql)
        {
            return connection.Query<T>(sql);
        }

        public void Dispose()
        {
            connection.Dispose();
        }
    }
}
