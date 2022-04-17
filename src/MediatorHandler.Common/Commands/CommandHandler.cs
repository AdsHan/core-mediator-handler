using MediatorHandler.Common.Mediator;

namespace MediatorHandler.Common.Commands;

public abstract class CommandHandler
{
    protected MediatorResult MediatorResult;

    protected CommandHandler()
    {
        MediatorResult = new MediatorResult();
    }

    protected void AddError(string message)
    {
        MediatorResult.Errors.Add(message);
    }

}
