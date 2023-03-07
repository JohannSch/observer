using Serilog;

using Server.Settings;

namespace Server.Helpers;

internal static class LoggerCreater
{
    public static Serilog.ILogger CreateConsole()
    {
        Log.Logger = new LoggerConfiguration()
            .WriteTo.Console(formatProvider: CultureSettings.DefaultCultureInfo)
            .CreateBootstrapLogger();

        return Log.Logger;
    }
}
