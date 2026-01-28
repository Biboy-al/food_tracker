using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddScoped<IFoodService, FoodService>();

builder.Services.AddDbContext<TrackerDbContext>(options =>
{
    var conString = builder.Configuration.GetConnectionString("DefaultConnection");
    options.UseNpgsql(conString);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

await using (var serviceScope = app.Services.CreateAsyncScope())
await using (var dbContext = serviceScope.ServiceProvider.GetRequiredService<TrackerDbContext>())
{
    await dbContext.Database.EnsureCreatedAsync();
}

app.MapFoodEndpoints();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
