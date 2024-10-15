namespace Core.Domain;

public class CategoryEnum
{
    public int CategoryId { get; set; }
    public required string Category { get; set; }
    public ICollection<Game>? Games { get; set; }
}