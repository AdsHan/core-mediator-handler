using MediatorHandler.Common.Commands;
using MediatorHandler.Common.Queries;

namespace MediatorHandler.Common.Mediator;

public interface IMediatorResolver
{
    Task<MediatorResult> SendCommand<T>(T command) where T : ICommand;
    Task<T> SendQuery<P, T>(P parameters) where P : IQuery;
}
