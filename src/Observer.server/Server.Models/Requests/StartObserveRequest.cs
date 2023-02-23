using Newtonsoft.Json;

namespace Server.Models.Requests;

public sealed record StartObserveRequest
{
    [JsonProperty("request_id")]
    public required Guid RequestId { get; init; }
}
