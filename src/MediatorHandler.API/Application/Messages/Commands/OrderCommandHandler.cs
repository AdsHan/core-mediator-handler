using MediatorHandler.Common.Commands;
using MediatorHandler.Common.Mediator;

namespace MediatorHandler.API.Application.Messages.Commands;

internal class OrderCommandHandler : CommandHandler,
                                     ICommandHandler<CreateOrderCommand>,
                                     ICommandHandler<UpdateOrderCommand>
{

    public async Task<MediatorResult> ExecuteCommandAsync(CreateOrderCommand command)
    {

        return MediatorResult;
    }

    public async Task<MediatorResult> ExecuteCommandAsync(UpdateOrderCommand command)
    {
        AddError("Ocorreu um erro!");

        return MediatorResult;
    }
}
