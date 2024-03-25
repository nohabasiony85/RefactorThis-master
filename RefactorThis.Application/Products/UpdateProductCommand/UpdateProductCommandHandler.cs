using RefactorThis.Application.Abstractions;
using RefactorThis.Application.Abstractions.Data;

namespace RefactorThis.Application.Products.UpdateProductCommand;

public class UpdateProductCommandHandler(ISqlDataConnectionFactory sqlDataConnectionFactory)
    : ICommandHandler<UpdateProductCommand>
{
    public Task Handle(UpdateProductCommand request, CancellationToken cancellationToken)
    {
        var connection = sqlDataConnectionFactory.CreateConnection();
        var cmd = connection.CreateCommand();

        cmd.CommandText =
            $"update Products set name = '{request.Name}', description = '{request.Description}', price = {request.Price}, deliveryprice = {request.DeliveryPrice} where id = '{request.Id}' collate nocase";

        cmd.ExecuteNonQuery();
        return Task.CompletedTask;
    }
}