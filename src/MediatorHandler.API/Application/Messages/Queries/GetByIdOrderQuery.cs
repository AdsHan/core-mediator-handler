using MediatorHandler.Common.Queries;

namespace MediatorHandler.API.Application.Messages.Queries;

public class GetByIdOrderQuery : IQuery
{
    public GetByIdOrderQuery(int id)
    {
        Id = id;
    }

    public int Id { get; set; }
}

