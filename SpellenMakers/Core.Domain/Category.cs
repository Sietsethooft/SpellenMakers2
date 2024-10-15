namespace Core.Domain;

public class Category
{
    public int CategoryId { get; set; }
    public required string Name { get; set; }
    public ICollection<Game>? Games { get; set; }
}