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

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
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
