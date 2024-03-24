using Microsoft.Data.Sqlite;
using RefactorThis.Application.Abstractions;
using RefactorThis.Application.Abstractions.Data;
using RefactorThis.Domain.Entities;

namespace RefactorThis.Application.Products.CreateProductCommand;

public class CreateProductCommandHandler(ISqlDataConnectionFactory sqlDataConnectionFactory) : ICommandHandler<CreateProductCommand>
{
    public Task Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        var connection = sqlDataConnectionFactory.CreateConnection();
        var cmd = connection.CreateCommand();

        cmd.CommandText =
            $"insert into Products where (name, desc, price, deliveryprice) values ({request.Name}', '{request.Description}', {request.Price}, {request.DeliveryPrice})";

        cmd.ExecuteNonQuery();
        return Task.CompletedTask;
    }
    
}