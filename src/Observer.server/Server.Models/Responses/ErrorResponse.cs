using Server.Models.Enums;

namespace Server.Models.Responses;

public sealed class ErrorResponse : ResponseBase
{
    public ErrorResponse(ResponseCode code, string? message = null) : base(code, message)
    {
    }
}
