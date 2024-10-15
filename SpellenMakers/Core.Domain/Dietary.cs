namespace Core.Domain;

public class Dietary
{
    public int DietaryId { get; set; }
    public bool isVegetarian { get; set; }
    public bool WantsAlcohol { get; set; }
    public bool HasLactose { get; set; }
    public bool HasNutAllergy { get; set; }
}
