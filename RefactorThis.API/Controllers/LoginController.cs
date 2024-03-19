using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Sqlite;
using RefactorThis.Domain.Models;

namespace RefactorThis.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase 
    {
        [HttpGet("{username}/{password}")]
        public IActionResult Login(string username, string password) 
        {
            var conn = Helpers.NewConnection<SqliteConnection>();
            conn.Open();
            var cmd = conn.CreateCommand();
            cmd.CommandText = $"select APIToken,APITokenExpiry from Login where name='{username}' and password='{password}'";

            var rdr = cmd.ExecuteReader();

            if (!rdr.Read())
                return BadRequest("You can't log in");

            var apiTokenExpiry = rdr["APITokenExpiry"].ToString();
            var realExpiryDate = DateTime.Today;

            // bug fix for default expiry dates from stackexchange
            if (DateTime.TryParse(apiTokenExpiry, out realExpiryDate)) {
                // that's good
            }

            if (DateTime.Now < realExpiryDate) {
                return Accepted("You are logged in and can use the API");
            }
            else 
            {
                return BadRequest("Your api token has expired, please ask Reliability for a new one to be assigned to you");
            }
        }
    }
}