using Newtonsoft.Json;

using Server.Models.Enums;

namespace Server.Models.Responses;

public sealed class Response : ResponseBase
{
    public Response(ResponseCode code, string value, Guid requestId, string? message = null) : base(code, message)
    {
        Value = value;
        RequestId = requestId;
    }

    [JsonProperty("value")]
    public string Value { get; }

    [JsonProperty("request_id")]
    public Guid RequestId { get; }
}
