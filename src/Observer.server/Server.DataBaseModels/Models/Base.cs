namespace Server.DataBaseModels.Models;

public abstract class Base
{
    public Guid Id { get; }

    public DateTime CreatedAt { get; }

    public Guid? CreatedBy { get; }

    public DateTime ModifiedAt { get; set; }

    public Guid? ModifiedBy { get; set; }
}
