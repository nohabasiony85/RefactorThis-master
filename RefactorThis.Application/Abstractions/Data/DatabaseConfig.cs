using System.ComponentModel.DataAnnotations;

namespace RefactorThis.Application.Abstractions.Data;

public class DatabaseConfig
{
    [Required] public required string ConnectionString { get; set; }
}