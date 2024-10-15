namespace Core.Domain;

public class GameNight_Games
{
    [Key]
    public int GameName { get; set; }
    public int GameNightId { get; set; }

    public required Game Game { get; set; } // Foreign Key to Game
    public required GameNight GameNight { get; set; } // Foreign Key to GameNight
}
