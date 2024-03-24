using Microsoft.Data.Sqlite;
using RefactorThis.Application.Abstractions;
using RefactorThis.Application.Abstractions.Data;

namespace RefactorThis.Application.Products.DeleteProductCommand;

public class DeleteProductCommandHandler(ISqlDataConnectionFactory sqlDataConnectionFactory) : ICommandHandler<DeleteProductCommand>
{
    public Task Handle(DeleteProductCommand request, CancellationToken cancellationToken)
    {
        var connection = sqlDataConnectionFactory.CreateConnection();
        var command = connection.CreateCommand();
        
        command.CommandText = "DELETE FROM ProductOptions WHERE productId = @ProductId; " +
                              "DELETE FROM Products WHERE id = @Id;";
        
        command.Parameters.Add(new SqliteParameter("@Id", request.Id));
        command.Parameters.Add(new SqliteParameter("@ProductId", request.Id));
        command.ExecuteNonQuery();

        return Task.CompletedTask;
    }
}