namespace Server.Extensions;

internal static class IConfigurationExtensions
{
    private const string DEFAULT_DB_CONNECTION_KEY = "DefaultDB";

    public static string GetDefaultDbConnectionString(this IConfiguration configuration)
    {
        return configuration.GetConnectionString(DEFAULT_DB_CONNECTION_KEY)
            ?? throw new InvalidOperationException("cannot get default db connection string");
    }
}
