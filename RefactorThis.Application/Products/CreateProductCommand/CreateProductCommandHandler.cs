using Microsoft.Data.Sqlite;
using RefactorThis.Application.Abstractions;
using RefactorThis.Application.Abstractions.Data;

namespace RefactorThis.Application.Products.CreateProductCommand;

public class CreateProductCommandHandler(ISqlDataConnectionFactory sqlDataConnectionFactory)
    : ICommandHandler<CreateProductCommand, bool>
{
    public Task<bool> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        var connection = sqlDataConnectionFactory.CreateConnection();
        var command = connection.CreateCommand();

        command.CommandText = "INSERT INTO Products (Id, Name, Description, Price, DeliveryPrice) " +
                              "VALUES (@Id, @Name, @Description, @Price, @DeliveryPrice)";

        command.Parameters.Add(new SqliteParameter("@Id", Guid.NewGuid()));
        command.Parameters.Add(new SqliteParameter("@Name", request.Name));
        command.Parameters.Add(new SqliteParameter("@Description", request.Description));
        command.Parameters.Add(new SqliteParameter("@Price", request.Price));
        command.Parameters.Add(new SqliteParameter("@DeliveryPrice", request.DeliveryPrice));

        var result = command.ExecuteNonQuery();
        return Task.FromResult(result > 0);
    }
}