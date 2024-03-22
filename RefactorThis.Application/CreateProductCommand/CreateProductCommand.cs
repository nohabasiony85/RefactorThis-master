using RefactorThis.Domain.Abstractions;

namespace RefactorThis.Application.CreateProductCommand;

public record CreateProductCommand(string Name, string Description, decimal Price, decimal DeliveryPrice) : ICommand<Guid>;