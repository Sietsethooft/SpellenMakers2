namespace Core.Domain;

public class Player
{
    public int UserId { get; set; }
    public int GameNightId { get; set; }
    
    public required User User { get; set; } // foreign key to User
    public required GameNight GameNight { get; set; } // foreign key to GameNight
}
