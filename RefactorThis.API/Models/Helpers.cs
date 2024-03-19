using System.Data.Common;

namespace RefactorThis.API.Models
{
    public class Helpers
    {
        //private const string ConnectionString = "Data Source=App_Data/products.db;Password=changemelat3r";
        private const string ConnectionString = "Data Source=App_Data/products.db"; // password doesn't work?? 

        public static T NewConnection<T>() where T : DbConnection, new() {
            // from stackexchange
            var newConnection = new T {ConnectionString = ConnectionString};
            return newConnection;
        }
    }
}