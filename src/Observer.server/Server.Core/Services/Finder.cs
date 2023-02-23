using Server.Abstractions.Parser;
using Server.Models.Requests;
using Server.Models.Responses;

namespace Server.Core.Services;

public sealed class Finder : IFinder
{
    public async Task<Response> FindValueAsync(FindValueRequest request)
    {
        return await Task.FromResult(new Response(Models.Enums.ResponseCode.SUCCESS, "ok", Guid.NewGuid()));
    }
}
