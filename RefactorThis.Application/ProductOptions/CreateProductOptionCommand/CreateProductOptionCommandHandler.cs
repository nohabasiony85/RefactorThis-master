using RefactorThis.Application.Abstractions;
using RefactorThis.Application.Abstractions.Data;

namespace RefactorThis.Application.ProductOptions.CreateProductOptionCommand;

public class CreateProductOptionCommandHandler(ISqlDataConnectionFactory sqlDataConnectionFactory)
    : ICommandHandler<CreateProductOptionCommand>
{
    public Task Handle(CreateProductOptionCommand request, CancellationToken cancellationToken)
    {
        var connection = sqlDataConnectionFactory.CreateConnection();
        var cmd = connection.CreateCommand();

        cmd.CommandText =
            $"insert into productoptions ( productid, name, description) values ('{request.ProductId}', '{request.Name}', '{request.Description}')";

        cmd.ExecuteNonQuery();
        return Task.CompletedTask;
    }
}