namespace RefactorThis.Api.Models;

public class ApiResponse(string message)
{
    public string Message { get; } = message;
}