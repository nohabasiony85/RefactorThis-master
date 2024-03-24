using RefactorThis.Application.Abstractions;
using RefactorThis.Application.Abstractions.Data;

namespace RefactorThis.Application.ProductOptions.DeleteProductOptionCommand;

public class DeleteProductOptionCommandHandler(ISqlDataConnectionFactory sqlDataConnectionFactory) : ICommandHandler<DeleteProductOptionCommand>
{
    public Task Handle(DeleteProductOptionCommand request, CancellationToken cancellationToken)
    {
        var connection = sqlDataConnectionFactory.CreateConnection();
        var cmd = connection.CreateCommand();
        cmd.CommandText = $"delete from productoptions where id = '{request.Id}'";
        cmd.ExecuteNonQuery();

        return Task.CompletedTask;
    }
}