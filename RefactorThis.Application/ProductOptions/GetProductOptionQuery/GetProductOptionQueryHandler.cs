using Microsoft.Data.Sqlite;
using RefactorThis.Application.Abstractions;
using RefactorThis.Application.Abstractions.Data;
using RefactorThis.Domain.Entities;

namespace RefactorThis.Application.ProductOptions.GetProductOptionQuery;

public class GetProductOptionQueryHandler(ISqlDataConnectionFactory sqlDataConnectionFactory) : IQueryHandler<GetProductOptionQuery, ProductOption>
{
    public Task<ProductOption> Handle(GetProductOptionQuery request, CancellationToken cancellationToken)
    {
        var productOption = new ProductOption();
        var connection = sqlDataConnectionFactory.CreateConnection();

        var command = connection.CreateCommand();
        command.CommandText = "SELECT * FROM productoptions WHERE id = @Id";
            
        command.Parameters.Add(new SqliteParameter("@Id", request.ProductId));
        var reader = command.ExecuteReader();

        while (reader.Read())
        {
            productOption.Id = reader.GetGuid(reader.GetOrdinal("Id"));
            productOption.ProductId = reader.GetGuid(reader.GetOrdinal("ProductId"));
            productOption.Name = reader.GetString(reader.GetOrdinal("Name"));
            productOption.Description = reader.GetString(reader.GetOrdinal("Description"));
        }

        return Task.FromResult(productOption);
    }
}