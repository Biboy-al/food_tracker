public class Food : EntityBase
{
    public required string Name {get; set;}
    public required float Carbs {get; set;}
    public required float Protein {get; set;}
    public required float Fat {get; set;}
    public required float Calories {get; set;}

    public float calculateCalories()
    {
        return 0;
    }

    public Food(
        string name,
        float carbs,
        float protein,
        float fat,
        float calories)
    {
        this.Name = name;
        this.Carbs = carbs;
        this.Protein = protein;
        this.Fat = fat;
        this.Calories = calculateCalories();
    }




}