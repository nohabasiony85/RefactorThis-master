﻿namespace RefactorThis.Domain.Models {
    public class ProductOption
    {
        public Guid Id { get; set; }

        public Guid ProductId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        // [JsonIgnore] public bool IsNew { get; }
        //
        // public ProductOption()
        // {
        //     Id = Guid.NewGuid();
        //     IsNew = true;
        // }

        // public ProductOption(Guid id)
        // {
        //     IsNew = true;
        //     var conn = Helpers.NewConnection<SqliteConnection>();
        //     conn.Open();
        //     var cmd = conn.CreateCommand();
        //
        //     // $ means it's sanitised
        //     cmd.CommandText = $"select * from productoptions where id = '{id}' collate nocase";
        //
        //     var rdr = cmd.ExecuteReader();
        //     if (!rdr.Read())
        //         return;
        //
        //     IsNew = false;
        //     Id = Guid.Parse(rdr["Id"].ToString());
        //     ProductId = Guid.Parse(rdr["ProductId"].ToString());
        //     Name = rdr["Name"].ToString();
        //     Description = (DBNull.Value == rdr["Description"]) ? null : rdr["Description"].ToString();
        // }

        // public void Save()
        // {
        //     var conn = Helpers.NewConnection<SqliteConnection>();
        //     conn.Open();
        //     var cmd = conn.CreateCommand();
        //
        //     cmd.CommandText = IsNew
        //         ? $"insert into productoptions (id, productid, name, description) values ('{Id}', '{ProductId}', '{Name}', '{Description}', '{IsNew}')"
        //         : $"update productoptions set name = '{Name}', description = '{Description}' where id = '{Id}' collate nocase";
        //
        //     cmd.ExecuteNonQuery();
        // }

        // public void Delete()
        // {
        //     var conn = Helpers.NewConnection<SqliteConnection>();
        //     conn.Open();
        //     var cmd = conn.CreateCommand();
        //     cmd.CommandText = $"deleet from productoptions where id = '{Id}' collate nocase";
        //     cmd.ExecuteReader();
        // }
    }
}
