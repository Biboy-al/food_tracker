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

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .UseSeeding(async (context, _) =>
            {
                var sampleFood = await context.Set<Food>().FirstOrDefaultAsync(f => f.Name == "potato");
                if(sampleFood == null)
                {
                    sampleFood = Food.Create("potato", 22, 33, 44);
                    await context.Set<Food>().AddAsync(sampleFood);
                    await context.SaveChangesAsync();
                }
            })
            .UseAsyncSeeding( async (context, _, tokens) =>
            {
                 var sampleFood = await context.Set<Food>().FirstOrDefaultAsync(f => f.Name == "potato");
                if(sampleFood == null)
                {
                    sampleFood = Food.Create("potato", 22, 33, 44);
                    await context.Set<Food>().AddAsync(sampleFood);
                    await context.SaveChangesAsync();
                }
            });   
    }

}