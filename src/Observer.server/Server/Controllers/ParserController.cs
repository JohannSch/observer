using Microsoft.AspNetCore.Mvc;

using Server.Abstractions.Observer;
using Server.Abstractions.Parser;
using Server.Models.Requests;
using Server.Models.Responses;

namespace Server.Controllers;

[ApiController]
[Route("[controller]")]
public sealed class ParserController : ControllerBase
{
    private readonly IFinder _finder;
    private readonly IObserver _observer;

    public ParserController(IFinder finder, IObserver observer)
    {
        _finder = finder;
        _observer = observer;
    }

    [HttpPost("findValue")]
    public async Task<Response> FindValueAsync(FindValueRequest request)
        => await _finder.FindValueAsync(request);

    [HttpPost("startObserve")]
    public async Task<Response> StartObserveAsync(StartObserveRequest request)
        => await _observer.StartObserveAsync(request);
}
