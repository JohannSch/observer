using Newtonsoft.Json;

using Server.Models.Enums;

namespace Server.Models.Responses;

public abstract class ResponseBase
{
    public ResponseBase(ResponseCode code, string? message = null)
    {
        Code = code;
        Message = message;
    }

    [JsonProperty("code")]
    public ResponseCode Code { get; }

    [JsonProperty("message")]
    public string? Message { get; }
}
