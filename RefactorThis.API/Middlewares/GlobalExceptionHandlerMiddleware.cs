using System.Net;
using FluentValidation;
using Newtonsoft.Json;
using RefactorThis.Api.Models;

namespace RefactorThis.Api.Middlewares;

public class GlobalExceptionHandlerMiddleware(RequestDelegate next)
{
    public (HttpStatusCode code, string message) GetResponse(Exception exception)
    {
        var code = exception switch
        {
            ValidationException or BadHttpRequestException => HttpStatusCode.BadRequest,
            _ => HttpStatusCode.InternalServerError
        };
        return (code, JsonConvert.SerializeObject(new ApiResponse(exception.Message)));
    }
    
    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await next(context);
        }
        catch (Exception exception)
        {
            var response = context.Response;
            response.ContentType = "application/json";
            
            // get the response code and message
            var (status, message) = GetResponse(exception);
            response.StatusCode = (int) status;
            await response.WriteAsync(message);
        }
    }
}