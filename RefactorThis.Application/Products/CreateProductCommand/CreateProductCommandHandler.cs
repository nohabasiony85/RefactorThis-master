using Microsoft.Data.Sqlite;
using RefactorThis.Application.Abstractions;
using RefactorThis.Domain.Entities;

namespace RefactorThis.Application.Products.CreateProductCommand;

public class CreateProductCommandHandler : ICommandHandler<CreateProductCommand, Guid>
{
    public async Task<Guid> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        var conn = Helpers.NewConnection<SqliteConnection>();
        conn.Open();
        var cmd = conn.CreateCommand();

        cmd.CommandText =
            $"insert into Products where (id, name, desc, price, deliveryprice) values ({request.Name}', '{request.Description}', {request.Price}, {request.DeliveryPrice})";

        conn.Open();
        cmd.ExecuteNonQuery();
        throw new NotImplementedException();
    }
}