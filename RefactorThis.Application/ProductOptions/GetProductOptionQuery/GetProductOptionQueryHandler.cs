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
        command.CommandText = $"select * from productoptions where id = '{request.ProductId}' collate nocase";

        var reader = command.ExecuteReader();

        while (reader.Read())
        {
            productOption.Id = (Guid)reader["Id"];
            productOption.ProductId = (Guid)reader["ProductId"];
            productOption.Name = (string)reader["Name"];
            productOption.Description = (string)reader["Description"];
        }

        return Task.FromResult(productOption);
    }
}