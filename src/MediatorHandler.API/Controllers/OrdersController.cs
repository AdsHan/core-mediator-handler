using MediatorHandler.API.Application.DTO;
using MediatorHandler.API.Application.Messages.Commands;
using MediatorHandler.API.Application.Messages.Queries;
using MediatorHandler.Common.Mediator;
using Microsoft.AspNetCore.Mvc;

namespace MediatorHandler.API.Utils;

[Produces("application/json")]
[Route("api/orders")]
[ApiController]
public class OrdersController : BaseController
{
    private readonly IMediatorResolver _mediator;

    public OrdersController(IMediatorResolver mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var orders = await _mediator.SendQuery<GetAllOrderQuery, List<OrderDTO>>(new GetAllOrderQuery());

        return ListUtils.isEmpty(orders) ? NotFound() : CustomResponse(orders);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
        var order = await _mediator.SendQuery<GetByIdOrderQuery, OrderDTO>(new GetByIdOrderQuery(id));

        return order == null ? NotFound() : CustomResponse(order);
    }

    [HttpPost]
    [ActionName("NewOrder")]
    public async Task<IActionResult> PostAsync()
    {
        var result = await _mediator.SendCommand(new CreateOrderCommand());

        return result.IsValid() ? CreatedAtAction("NewOrder", new { id = result.Response }) : CustomResponse(result.Errors);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutAsync(int id)
    {
        var result = await _mediator.SendCommand(new UpdateOrderCommand(id));

        return CustomResponse(result);
    }
}
