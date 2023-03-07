using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

using Server.Abstractions.Contexts;
using Server.DataBaseLogic.Contexts;

namespace Server.DataBaseLogic.Extensions;

public static class IServiceCollectionExtensions
{
    public static IServiceCollection AddObserverDataBase(this IServiceCollection services, string connectionString)
    {
        services.RegisterContexts(connectionString);

        return services;
    }

    private static IServiceCollection RegisterContexts(this IServiceCollection services, string connectionString)
    {
        services.AddScoped<IObserverContext, ObserverContext>();

        services.AddDbContextPool<ObserverContext>(options =>
        {
            options.UseNpgsql(connectionString);
        });

        return services;
    }
}
