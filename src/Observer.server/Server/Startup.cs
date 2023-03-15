using Server.Abstractions.Contexts;
using Server.Core.Extensions;
using Server.DataBaseLogic.Extensions;
using Server.Extensions;

namespace Server;

internal sealed class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public readonly IConfiguration Configuration;

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddObserverControllers();
        services.AddObserverServices();
        services.AddObserverDataBase(Configuration.GetDefaultDbConnectionString());

        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
    }

#pragma warning disable CA1822 // Mark members as static
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IObserverContext context)
#pragma warning restore CA1822 // Mark members as static
    {
        context.Migrate();

        if (env.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseRouting();
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}
