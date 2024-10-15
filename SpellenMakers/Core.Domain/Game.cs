namespace Core.Domain;

public class Game
{
    public int GameId { get; set; }
    public required string Name { get; set; }
    public required string GameDescription { get; set; }
    public bool Is18Plus { get; set; }
    public required byte[] Picture { get; set; }

    public int GenreId { get; set; }// Navigation property
    public required Genre Genre { get; set; } // Foreign Key to GenreEnum

    public int CategoryId { get; set; }// Navigation property
    public required Category Category { get; set; } // Foreign Key to CategoryEnum

    public ICollection<GameNight_Games>? GameNight_Games { get; set; }
}
