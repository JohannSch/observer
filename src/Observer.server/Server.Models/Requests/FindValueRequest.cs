using Newtonsoft.Json;

namespace Server.Models.Requests;

public sealed record FindValueRequest
{
    [JsonProperty("locator_url")]
    public required string LocatorUrl { get; init; }

    [JsonProperty("locator")]
    public required string Locator { get; init; }
}
