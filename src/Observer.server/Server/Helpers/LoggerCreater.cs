using Serilog;

using Server.Settings;

namespace Server.Helpers;

public sealed class LoggerCreater
{
    public static Serilog.ILogger CreateConsole()
    {
        Log.Logger = new LoggerConfiguration()
            .WriteTo.Console(formatProvider: CultureSettings.DefaultCultureInfo)
            .CreateBootstrapLogger();

        return Log.Logger;
    }
}
