namespace Core.Domain;

public class GameNight
{
    public int GameNightId { get; set; }
    public int MaxCountPlayers { get; set; }
    public DateTime Date { get; set; }
    public TimeOnly Time { get; set; }
    public bool BringSnacks { get; set; }

    public required User Organizer { get; set; } // Foreign Key to User
    public required Address AddressId { get; set; } // Foreign Key to Address

    public ICollection<Player>? Players { get; set; }
    public ICollection<GameNight_Snack>? Snacks { get; set; }
    public required ICollection<GameNight_Games> Games { get; set; }
}