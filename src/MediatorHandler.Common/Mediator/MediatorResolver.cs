using MediatorHandler.Common.Commands;
using MediatorHandler.Common.Queries;

namespace MediatorHandler.Common.Mediator;

public class MediatorResolver : IMediatorResolver
{
    private readonly DependencyInjectionMediator _dependencyResolver;

    public MediatorResolver(DependencyInjectionMediator dependencyResolver)
    {
        _dependencyResolver = dependencyResolver;
    }

    public async Task<MediatorResult> SendCommand<T>(T command) where T : ICommand
    {
        var handler = _dependencyResolver.Resolve<ICommandHandler<T>>();

        return await handler.ExecuteCommandAsync(command);
    }

    public async Task<T> SendQuery<P, T>(P parameters) where P : IQuery
    {
        var handler = _dependencyResolver.Resolve<IQueryHandler<P, T>>();

        return await handler.ExecuteQueryAsync(parameters);
    }
}
