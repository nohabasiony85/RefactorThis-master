namespace RefactorThis.Domain.Entities {
    public class Product
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public decimal DeliveryPrice { get; set; }
        

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
