
using Microsoft.AspNetCore;

namespace Server;

public sealed class Program
{
    public static void Main(string[] args)
    {
        WebHost
            .CreateDefaultBuilder(args)
            .UseStartup<Startup>()
            .Build()
            .Run();
    }
}