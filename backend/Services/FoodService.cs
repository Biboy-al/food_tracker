
using System.Data.Common;
using Microsoft.EntityFrameworkCore;

class FoodService : IFoodService
{

    private readonly TrackerDbContext _dbContext;
    private readonly ILogger<FoodService> _service;

    public FoodService(TrackerDbContext dbContext, ILogger<FoodService> service)
    {
        _dbContext = dbContext;
        _service = service;

    }

    public async Task<FoodDto> CreateFoodAsync(CreateFoodDto cmd)
    {
        var food = Food.Create(cmd.Name, cmd.Carbs, cmd.Protein, cmd.Fat);

        await _dbContext.Foods.AddAsync(food);
        await _dbContext.SaveChangesAsync();

        return new FoodDto(food.Name, food.Carbs, food.Protein, food.Fat, food.Calories);
    }

    public async Task<IEnumerable<FoodDto>> getAllFoodAsync()
    {
        return await _dbContext.Foods
            .AsNoTracking()
            .Select(food => new FoodDto(food.Name, food.Carbs, food.Protein, food.Fat, food.Calories))
            .ToListAsync();
    }

    public Task<FoodDto> getFoodByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }
}