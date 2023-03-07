namespace Server.Extensions;

internal static class IServiceCollectionExtensions
{
    public static IServiceCollection AddObserverControllers(this IServiceCollection services)
    {
        services.AddControllers()
                .AddNewtonsoftJson(options =>
                {
                    options.SerializerSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
                });

        return services;
    }
}
