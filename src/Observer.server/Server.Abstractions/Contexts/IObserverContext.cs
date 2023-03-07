using Microsoft.EntityFrameworkCore;

using Server.DataBaseModels.Models.Requests;

namespace Server.Abstractions.Contexts;

public interface IObserverContext
{
    DbSet<FindRequest> FindRequest { get; }
}
