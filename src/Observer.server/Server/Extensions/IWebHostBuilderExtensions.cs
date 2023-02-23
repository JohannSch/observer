using Serilog;

namespace Server.Extensions;

public static class IWebHostBuilderExtensions
{
    public static IHostBuilder ConfigureSerilog(this IHostBuilder hostBuilder)
    {
        hostBuilder.UseSerilog((context, services, configuration) =>
        {
            configuration.ReadFrom.Configuration(context.Configuration);
        });

        return hostBuilder;
    }
}
