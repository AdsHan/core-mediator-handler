namespace MediatorHandler.API.Application.DTO;

public class OrderDTO
{
    public OrderDTO(int id, int customerId)
    {
        Id = id;
        CustomerId = customerId;
    }

    public int Id { get; set; }
    public int CustomerId { get; set; }
}
