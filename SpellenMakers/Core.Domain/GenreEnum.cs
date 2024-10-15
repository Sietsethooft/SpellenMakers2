namespace Core.Domain;

public class GenreEnum
{
    public int GenreId { get; set; }
    public required string Genre { get; set; }
    public ICollection<Game>? Games { get; set; }
}