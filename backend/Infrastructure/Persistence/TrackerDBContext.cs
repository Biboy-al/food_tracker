using System.Data.Common;
using Microsoft.EntityFrameworkCore;

public class TrackerDbContext(DbContextOptions<TrackerDbContext> options) : DbContext(options)
{

    public DbSet<Food> Foods => Set<Food>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("app");
        // Finds all classes that implements configuration and apply it here
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(TrackerDbContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }

}