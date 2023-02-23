using Server.Models.Requests;
using Server.Models.Responses;

namespace Server.Abstractions.Observer;
public interface IObserver
{
    Task<Response> StartObserveAsync(StartObserveRequest request);
}
