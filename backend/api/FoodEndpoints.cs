public static class FoodEndpoints
{
    public static void MapFoodEndpoints(this IEndpointRouteBuilder routes)
    {
        var foodApi = routes.MapGroup("/food").WithTags("Food");

        foodApi.MapPost("/", async (IFoodService service, CreateFoodDto food) =>
        {
            var createdFood = service.CreateFoodAsync(food);
            return TypedResults.Created("", createdFood);
        });

        foodApi.MapGet("/", async (IFoodService service) =>
        {
            var food = await service.getAllFoodAsync();
            return TypedResults.Ok(food);
        });
    }
}