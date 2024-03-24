using Microsoft.Data.Sqlite;
using RefactorThis.Application.Abstractions;
using RefactorThis.Domain.Entities;

namespace RefactorThis.Application.Products.UpdateProductCommand;

public class UpdateProductCommandHandler : ICommandHandler<UpdateProductCommand>
{
    public Task Handle(UpdateProductCommand request, CancellationToken cancellationToken)
    {
        var conn = Helpers.NewConnection<SqliteConnection>();
        conn.Open();
        var cmd = conn.CreateCommand();

        cmd.CommandText =
            $"update Products set name = '{request.Name}', description = '{request.Description}', price = {request.Price}, deliveryprice = {request.DeliveryPrice} where id = '{request.Id}' collate nocase";

        conn.Open();
        cmd.ExecuteNonQuery();
        return Task.CompletedTask;
    }
}