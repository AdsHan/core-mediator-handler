using MediatorHandler.Common.Mediator;

namespace MediatorHandler.Common.Commands;

public interface ICommandHandler<T> where T : ICommand
{
    Task<MediatorResult> ExecuteCommandAsync(T command);
}

