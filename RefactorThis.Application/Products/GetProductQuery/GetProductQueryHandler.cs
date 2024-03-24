using System.Data;
using Microsoft.Data.Sqlite;
using RefactorThis.Application.Abstractions;
using RefactorThis.Application.Abstractions.Data;
using RefactorThis.Domain.Entities;

namespace RefactorThis.Application.Products.GetProductQuery;

public class GetProductQueryHandler(ISqlDataConnectionFactory sqlDataConnectionFactory) : IQueryHandler<GetProductQuery, Product>
{
    public Task<Product> Handle(GetProductQuery request, CancellationToken cancellationToken)
    {    
        var product = new Product();
        using (var connection = sqlDataConnectionFactory.CreateConnection())
        {
            var command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM products WHERE id = @Id";
            
            command.Parameters.Add(new SqliteParameter("@Id", request.Id));

            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                product.Id = reader.GetGuid(reader.GetOrdinal("Id"));
                product.Name = reader.GetString(reader.GetOrdinal("Name"));
                product.Description = reader.GetString(reader.GetOrdinal("Description"));
                product.Price = reader.GetDecimal(reader.GetOrdinal("Price"));
                product.DeliveryPrice = reader.GetDecimal(reader.GetOrdinal("DeliveryPrice"));
            }
        }

        return Task.FromResult(product);
    }
}