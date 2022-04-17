using MediatorHandler.API.Application.DTO;
using MediatorHandler.API.Application.Messages.Commands;
using MediatorHandler.API.Application.Messages.Queries;
using MediatorHandler.Common.Commands;
using MediatorHandler.Common.Mediator;
using MediatorHandler.Common.Queries;

namespace MediatorHandler.API.Configuration;

public static class DependencyInjectionConfig
{
    public static IServiceCollection AddDependencyConfiguration(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddSingleton<DependencyInjectionMediator>();
        services.AddSingleton<IMediatorResolver, MediatorResolver>();

        services.AddTransient<ICommandHandler<CreateOrderCommand>, OrderCommandHandler>();
        services.AddTransient<ICommandHandler<UpdateOrderCommand>, OrderCommandHandler>();

        services.AddTransient<IQueryHandler<GetAllOrderQuery, List<OrderDTO>>, OrderQueryHandler>();
        services.AddTransient<IQueryHandler<GetByIdOrderQuery, OrderDTO>, OrderQueryHandler>();

        return services;
    }
}
