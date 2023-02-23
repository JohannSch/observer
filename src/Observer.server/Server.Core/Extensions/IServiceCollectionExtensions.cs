using Microsoft.Extensions.DependencyInjection;

using Server.Abstractions.Observer;
using Server.Abstractions.Parser;
using Server.Core.Services;

namespace Server.Core.Extensions;
public static class IServiceCollectionExtensions
{
    public static IServiceCollection AddObserverServices(this IServiceCollection services)
    {
        services.AddTransient<IFinder, Finder>();
        services.AddTransient<IObserver, Observer>();

        return services;
    }
}
