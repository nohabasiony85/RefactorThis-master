using Microsoft.Data.Sqlite;
using RefactorThis.Application.Abstractions;
using RefactorThis.Application.Abstractions.Data;

namespace RefactorThis.Application.ProductOptions.CreateProductOptionCommand;

public class CreateProductOptionCommandHandler(ISqlDataConnectionFactory sqlDataConnectionFactory)
    : ICommandHandler<CreateProductOptionCommand>
{
    public Task Handle(CreateProductOptionCommand request, CancellationToken cancellationToken)
    {
        var connection = sqlDataConnectionFactory.CreateConnection();
        var command = connection.CreateCommand();

        command.CommandText = "INSERT INTO ProductOptions (Id, productid, Name, Description) " +
                              "VALUES (@Id, @ProductId, @Name, @Description)";

        command.Parameters.Add(new SqliteParameter("@Id", Guid.NewGuid()));
        command.Parameters.Add(new SqliteParameter("@ProductId", request.ProductId));
        command.Parameters.Add(new SqliteParameter("@Name", request.Name));
        command.Parameters.Add(new SqliteParameter("@Description", request.Description));
        
        command.ExecuteNonQuery();
        return Task.CompletedTask;
    }
}