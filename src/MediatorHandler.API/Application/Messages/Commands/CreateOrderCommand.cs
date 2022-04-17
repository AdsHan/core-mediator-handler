using MediatorHandler.Common.Commands;

namespace MediatorHandler.API.Application.Messages.Commands;

public class CreateOrderCommand : ICommand
{
    public int Id { get; set; }
}

