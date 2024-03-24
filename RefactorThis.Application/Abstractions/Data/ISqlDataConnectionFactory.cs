using Microsoft.AspNet.SignalR;

namespace RefactorThis.Application.Abstractions.Data;

public interface ISqlDataConnectionFactory {
    IConnection CreateConnection();
}