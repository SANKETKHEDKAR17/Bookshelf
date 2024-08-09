using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace Application.bookshelf.Infractructure
{
    public class BookShelfDbContext
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;

        public BookShelfDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = configuration.GetConnectionString("BookShelfDb"); // Corrected key
        }

        public IDbConnection CreateConnection() => new SqlConnection(_connectionString);
    }
}
