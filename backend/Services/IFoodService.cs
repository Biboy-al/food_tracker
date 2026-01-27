public interface IFoodService
{
    Task<FoodDto> CreateFoodAsync(CreateFoodDto food);
    Task<FoodDto> getFoodByIdAsync(Guid id);
    Task<IEnumerable<FoodDto>> getAllFoodAsync(); 
} 