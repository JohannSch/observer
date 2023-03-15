using Server.Extensions;
using Server.Helpers;

namespace Server;

public sealed class Program
{
    public static void Main(string[] args)
    {
        try
        {
            IHostBuilder hostBuilder = Host.CreateDefaultBuilder(args);

            hostBuilder
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                })
                .ConfigureSerilog();

            IHost host = hostBuilder.Build();
            host.Run();
        } catch (Exception ex)
        {
            Serilog.ILogger logger = LoggerHelper.CreateConsole();
            logger.Fatal(ex.ToString());
        }
    }
}
