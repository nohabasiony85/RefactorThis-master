using RefactorThis.Application.Abstractions;
using RefactorThis.Application.Abstractions.Data;
using RefactorThis.Domain.Entities;

namespace RefactorThis.Application.Products.GetProductQuery;

public class GetProductQueryHandler(ISqlDataConnectionFactory sqlDataConnectionFactory) : IQueryHandler<GetProductQuery, Product>
{
    public Task<Product> Handle(GetProductQuery request, CancellationToken cancellationToken)
    {    
        var product = new Product();
        var connection = sqlDataConnectionFactory.CreateConnection();

        var command = connection.CreateCommand();
        command.CommandText = $"select * from products where id = '{request.Id}'";

        var reader = command.ExecuteReader();

        while (reader.Read())
        {
            product.Id = (Guid)reader["Id"];
            product.Name = (string)reader["Name"];
            product.Description = (string)reader["Description"];
            product.Price = (decimal)reader["Price"];
            product.DeliveryPrice = (decimal)reader["DeliveryPrice"];
        }

        return Task.FromResult(product);
    }
}