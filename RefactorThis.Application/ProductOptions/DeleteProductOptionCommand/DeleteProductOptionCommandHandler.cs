using Microsoft.Data.Sqlite;
using RefactorThis.Application.Abstractions;
using RefactorThis.Domain.Entities;

namespace RefactorThis.Application.ProductOptions.DeleteProductOptionCommand;

public class DeleteProductOptionCommandHandler : ICommandHandler<DeleteProductOptionCommand>
{
    public Task Handle(DeleteProductOptionCommand request, CancellationToken cancellationToken)
    {
        var conn = Helpers.NewConnection<SqliteConnection>();
        conn.Open();
        var cmd = conn.CreateCommand();
        cmd.CommandText = $"delete from productoptions where id = '{request.Id}'";
        cmd.ExecuteReader();

        return Task.CompletedTask;
    }
}