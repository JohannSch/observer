using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

using Server.Abstractions.Contexts;
using Server.DataBaseModels.Models;
using Server.DataBaseModels.Models.Requests;

namespace Server.DataBaseLogic.Contexts;

internal sealed class ObserverContext : DbContext, IObserverContext
{
    public ObserverContext(DbContextOptions options) : base(options) { }

    public DbSet<FindRequest> FindRequest { get; init; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnBaseCreating(modelBuilder);
    }

    private static void OnBaseCreating(ModelBuilder modelBuilder)
    {
        IEnumerable<IMutableEntityType> entities = modelBuilder.Model.GetEntityTypes();

        string idPropertyName = nameof(Base.Id);
        IEnumerable<Type> iBaseEntityTypes = entities.Where(e => e.ClrType.IsSubclassOf(typeof(Base))).Select(e => e.ClrType);
        foreach (Type entityType in iBaseEntityTypes)
        {
            Console.WriteLine($"type: {entityType.Name}");

            modelBuilder.Entity(entityType)
                .HasKey(idPropertyName);

            modelBuilder.Entity(entityType)
                .Property(idPropertyName)
                .HasColumnType("uuid")
                .HasDefaultValueSql("uuid_generate_v4()")
                .IsRequired();
        }

        IEnumerable<IMutableForeignKey> foreignKeys = entities.SelectMany(e => e.GetForeignKeys());
        foreach (IMutableForeignKey key in foreignKeys)
        {
            key.DeleteBehavior = DeleteBehavior.Restrict;
        }
    }
}
