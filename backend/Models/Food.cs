public class Food : EntityBase
{
    public string Name {get; set;}
    public float Carbs {get; set;}
    public float Protein {get; set;}
    public float Fat {get; set;}
    public float Calories {get; set;}

    private Food(string name, float carbs, float protein, float fat, float calories)
    {
        this.Name = name;
        this.Carbs = carbs;
        this.Protein = protein;
        this.Fat = fat;
        this.Calories = calories;
    }

    public static Food Create( string name, float carbs, float protein, float fat)
    {
        float calories = (carbs * 4) + (protein * 4) + (fat * 9);
        return new Food(name, carbs, protein, fat, calories);
    }

}