using Microsoft.Data.Sqlite;
using RefactorThis.Application.Abstractions;
using RefactorThis.Application.Abstractions.Data;

namespace RefactorThis.Application.Login.LoginQuery;

public class LoginQueryHandler(ISqlDataConnectionFactory sqlDataConnectionFactory) : IQueryHandler<LoginQuery, LoginQueryResponse>
{
    public async Task<LoginQueryResponse> Handle(LoginQuery request, CancellationToken cancellationToken)
    {
        var connection = sqlDataConnectionFactory.CreateConnection();

        var command = connection.CreateCommand();
        command.CommandText = $"select APIToken,APITokenExpiry from Login where name= @Name and password= #Password";

        command.Parameters.Add(new SqliteParameter("@Name", request.UserName));
        command.Parameters.Add(new SqliteParameter("@Password", request.Password));

        var reader = command.ExecuteReader();

        if (!reader.Read())
            return new LoginQueryResponse(false, "You can't log in");

        var apiTokenExpiry = reader.GetString(reader.GetOrdinal("APITokenExpiry"));

        // bug fix for default expiry dates from stackexchange
        if (DateTime.TryParse(apiTokenExpiry, out var realExpiryDate))
        {
            // that's good
        }

        return DateTime.Now < realExpiryDate ? new LoginQueryResponse(true, "You are logged in and can use the API") : new LoginQueryResponse(false, "Your api token has expired, please ask Reliability for a new one to be assigned to you");
    }
}