using System.Data;
using Microsoft.Data.Sqlite;
using Microsoft.Extensions.Options;

namespace RefactorThis.Application.Abstractions.Data;

public class SqlDataConnectionFactory(IOptions<DatabaseConfig> databaseConfig) : ISqlDataConnectionFactory
{
    public IDbConnection CreateConnection()
    {
        var connectionString = databaseConfig.Value.ConnectionString;
        var connection = new SqliteConnection(connectionString);

        connection.Open();

        return connection;
    }
}