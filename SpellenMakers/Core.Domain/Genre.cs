namespace Core.Domain;

public class Genre
{
    public int GenreId { get; set; }
    public required string Name { get; set; }
    public ICollection<Game>? Games { get; set; }
}