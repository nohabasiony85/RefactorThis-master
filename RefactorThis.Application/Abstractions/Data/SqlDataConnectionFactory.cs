using Microsoft.AspNet.SignalR;
using Microsoft.Extensions.Options;

namespace RefactorThis.Application.Abstractions.Data;

public class SqlDataConnectionFactory(IOptions<DatabaseConfig> databaseConfig) : ISqlDataConnectionFactory
{
    
    public IConnection CreateConnection() {
        var connectionString =  databaseConfig.Value.ConnectionString;
        //create and return connection object here

    }
}

public class DatabaseConfig
{
    public string ConnectionString { get; set; }
}