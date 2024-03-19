using System;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;

namespace RefactorThis.API.Models
{
    public class Products
    {
        public List<Product> Items { get; private set; }

        public Products(string name)
        {
            switch (name) {
                case "test":
                    LoadProducts("where 1=1");
                    break;

                case null:
                    Items = new List<Product>();
                    break;

                default:
                    LoadProducts($"where lower(name) like '%{name.ToLower()}%'");
                    break;
            }
            
        }

        private void LoadProducts(string where)
        {
            Items = new List<Product>();
            var conn = Helpers.NewConnection<SqliteConnection>();
            conn.Open();
            var cmd = conn.CreateCommand();
            cmd.CommandText = $"select id from Products {where}";

            var rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                var id = Guid.Parse(rdr.GetString(0));
                Items.Add(new Product(id));
            }
        }
    }
}