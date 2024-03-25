using System.Data;

namespace RefactorThis.Application.Abstractions.Data;

public interface ISqlDataConnectionFactory
{
    IDbConnection CreateConnection();
}