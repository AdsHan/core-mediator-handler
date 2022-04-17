using Microsoft.Extensions.DependencyInjection;

namespace MediatorHandler.Common.Mediator;

public class DependencyInjectionMediator
{
    private readonly IServiceProvider _serviceProvider;

    public DependencyInjectionMediator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public T Resolve<T>() => _serviceProvider.GetRequiredService<T>();
}
