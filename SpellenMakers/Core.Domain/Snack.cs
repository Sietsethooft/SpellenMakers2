namespace Core.Domain;

public class Snack
{
    public int SnackId { get; set; }
    public required string Name { get; set; }
    public bool IsVegetarian { get; set; }
    public bool HasAlcohol { get; set; }
    public bool HasLactose { get; set; }
    public bool HasNuts { get; set; }

    public ICollection<GameNight_Snack>? GameNight_Snacks { get; set; }
}