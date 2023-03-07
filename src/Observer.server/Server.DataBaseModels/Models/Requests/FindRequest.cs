namespace Server.DataBaseModels.Models.Requests;

public sealed class FindRequest : Base
{
    public string LocatorUrl { get; set; } = default!;

    public string Locator { get; set; } = default!;

    public string RequestName { get; set; } = default!;
}
