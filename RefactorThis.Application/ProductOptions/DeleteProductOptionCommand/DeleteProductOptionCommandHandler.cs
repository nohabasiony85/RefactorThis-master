using Microsoft.Data.Sqlite;
using RefactorThis.Application.Abstractions;
using RefactorThis.Application.Abstractions.Data;

namespace RefactorThis.Application.ProductOptions.DeleteProductOptionCommand;

public class DeleteProductOptionCommandHandler(ISqlDataConnectionFactory sqlDataConnectionFactory) : ICommandHandler<DeleteProductOptionCommand>
{
    public Task Handle(DeleteProductOptionCommand request, CancellationToken cancellationToken)
    {
        var connection = sqlDataConnectionFactory.CreateConnection();
        var command = connection.CreateCommand();
        
        command.CommandText = "DELETE FROM ProductOptions WHERE id = @Id AND ProductId = @ProductId";
        
        command.Parameters.Add(new SqliteParameter("@Id", request.Id));
        command.Parameters.Add(new SqliteParameter("@ProductId", request.ProductId));
        command.ExecuteNonQuery();

        return Task.CompletedTask;
    }
}