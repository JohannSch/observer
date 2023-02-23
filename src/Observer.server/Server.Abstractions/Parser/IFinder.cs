using Server.Models.Requests;
using Server.Models.Responses;

namespace Server.Abstractions.Parser;

public interface IFinder
{
    public Task<Response> FindValueAsync(FindValueRequest request);
}
