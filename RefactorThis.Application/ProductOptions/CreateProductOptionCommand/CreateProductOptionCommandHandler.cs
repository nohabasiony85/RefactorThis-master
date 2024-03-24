using Microsoft.Data.Sqlite;
using RefactorThis.Application.Abstractions;
using RefactorThis.Domain.Entities;

namespace RefactorThis.Application.ProductOptions.CreateProductOptionCommand;

public class CreateProductOptionCommandHandler : ICommandHandler<CreateProductOptionCommand>
{
    public Task Handle(CreateProductOptionCommand request, CancellationToken cancellationToken)
    {
        var conn = Helpers.NewConnection<SqliteConnection>();
        conn.Open();
        var cmd = conn.CreateCommand();

        cmd.CommandText =
            $"insert into productoptions ( productid, name, description) values ('{request.ProductId}', '{request.Name}', '{request.Description}')";
        
        cmd.ExecuteNonQuery();
        return Task.CompletedTask;
    }
}