using MediatorHandler.API.Application.DTO;
using MediatorHandler.Common.Queries;

namespace MediatorHandler.API.Application.Messages.Queries;

public class OrderQueryHandler : IQueryHandler<GetAllOrderQuery, List<OrderDTO>>,
                                 IQueryHandler<GetByIdOrderQuery, OrderDTO>
{

    public async Task<List<OrderDTO>> ExecuteQueryAsync(GetAllOrderQuery request)
    {
        var list = new List<OrderDTO>() { new OrderDTO(1, 1) };
        return list;
    }

    public async Task<OrderDTO> ExecuteQueryAsync(GetByIdOrderQuery request)
    {
        return new OrderDTO(2, 2);
    }

}
