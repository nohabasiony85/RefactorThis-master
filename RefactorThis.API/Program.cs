using RefactorThis.Api.Middlewares;
using RefactorThis.Domain.Products.CreateProductCommand;
using RefactorThis.Domain.Validators;
using RefactorThis.Domain.Validators.Product;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddMediatR(configuration =>
{
    configuration.RegisterServicesFromAssembly(typeof(CreateProductCommand).Assembly);
	
    configuration.AddOpenBehavior(typeof(ValidationBehavior<,>));
});

// builder.Services.AddValidatorsFromAssembly(typeof(CreateProductCommandValidator).Assembly);


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseMiddleware<GlobalExceptionHandlerMiddleware>();

app.UseAuthorization();

app.MapControllers();

app.Run();