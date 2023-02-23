using Server.Abstractions.Observer;
using Server.Models.Requests;
using Server.Models.Responses;

namespace Server.Core.Services;

public sealed class Observer : IObserver
{
    public async Task<Response> StartObserveAsync(StartObserveRequest request)
    {
        return await Task.FromResult(new Response(Models.Enums.ResponseCode.SUCCESS, "ok", Guid.NewGuid()));
    }
}
