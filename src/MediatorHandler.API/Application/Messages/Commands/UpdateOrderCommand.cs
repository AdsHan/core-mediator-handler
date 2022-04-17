using MediatorHandler.Common.Commands;

namespace MediatorHandler.API.Application.Messages.Commands;

public class UpdateOrderCommand : ICommand
{
    public int Id { get; set; }

    public UpdateOrderCommand(int id)
    {
        Id = id;
    }
}
