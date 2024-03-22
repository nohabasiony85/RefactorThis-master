using RefactorThis.Domain.Abstractions;

namespace RefactorThis.Domain.Entities {
    public class Product(Guid id, string name, string description, decimal price, decimal deliveryPrice)
        : Entity(id)
    {
        public Guid Id { get; set; }

        public required string Name { get; init; } = name;

        public required string Description { get; init; } = description;

        public decimal Price { get; init; } = price;

        public decimal DeliveryPrice { get; init; } = deliveryPrice;

        // [JsonIgnore] public bool IsNew { get; }

        // public Product()
        // {
        //     Id = Guid.NewGuid();
        //     IsNew = true;
        // }

        // public Product(Guid id)
        // {
        //     IsNew = true;
        //     var conn = Helpers.NewConnection<SqliteConnection>();
        //     conn.Open();
        //     var cmd = conn.CreateCommand();
        //     cmd.CommandText = $"select * from Products where id = '{id}' collate nocase";
        //
        //     var rdr = cmd.ExecuteReader();
        //     if (!rdr.Read())
        //         return;
        //
        //     IsNew = false;
        //     Id = Guid.Parse(rdr["Id"].ToString());
        //     Name = rdr["Name"].ToString();
        //     Description = (DBNull.Value == rdr["Description"]) ? null : rdr["Description"].ToString();
        //     Price = decimal.Parse(rdr["Price"].ToString());
        //     DeliveryPrice = decimal.Parse(rdr["DeliveryPrice"].ToString());
        // }

        // public void Save()
        // {
        //     var conn = Helpers.NewConnection<SqliteConnection>();
        //     conn.Open();
        //     var cmd = conn.CreateCommand();
        //
        //     cmd.CommandText = IsNew
        //         ? $"insert into Products where (id, name, desc, price, deliveryprice) values ('{Id}', '{Name}', '{Description}', {Price}, {DeliveryPrice})"
        //         : $"update Products set name = '{Name}', description = '{Description}', price = {Price}, deliveryprice = {DeliveryPrice} where id = '{Id}' collate nocase";
        //
        //     conn.Open();
        //     cmd.ExecuteNonQuery();
        // }

        // public void Delete()
        // {
        //     foreach (var option in new ProductOptions(Id).Items)
        //         option.Delete();
        //
        //     var conn = Helpers.NewConnection<SqliteConnection>();
        //     conn.Open();
        //     var cmd = conn.CreateCommand();
        //
        //     cmd.CommandText = $"delete from Products where id = '{Id}' collate nocase";
        //     cmd.ExecuteNonQuery();
        // }
    }
}
