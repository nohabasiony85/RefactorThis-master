namespace RefactorThis.Domain.Entities;

public class ProductOptions
{
    //public IEnumerable<ProductOption> Items { get; private set; } = new ProductOption[1]; // probably singleton

    // public ProductOptions()
    // {
    //     LoadProductOptions(null);
    // }

    // public ProductOptions(Guid productId)
    // {
    //     LoadProductOptions($"where productid = 'productId' collate nocase");
    // }

    // private void LoadProductOptions(string where)
    // {
    //     Items = new List<ProductOption>();
    //     var conn = Helpers.NewConnection<SqliteConnection>();
    //     conn.Open();
    //     var cmd = conn.CreateCommand();
    //
    //     cmd.CommandText = $"select id from productoptions {where}";
    //
    //     var rdr = cmd.ExecuteReader();
    //     while (rdr.Read())
    //     {
    //         var id = Guid.Parse(rdr.GetString(0));
    //         Items.ToList().Add(new ProductOption(id));
    //     }
    // }
}