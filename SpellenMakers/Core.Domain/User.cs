namespace Core.Domain;

public class User
{
    public int UserId { get; set; }
    public required string Name { get; set; }
    public required string Email { get; set; }
    public DateTime Birthday { get; set; }

    public int GenderId { get; set; } // Navigation property
    public required Gender Gender { get; set; } // Foreign Key to GenderEnum

    public int DietaryId { get; set; } // Navigation property
    public required Dietary Dietary { get; set; } // Foreign Key to Dietary

    public int AddressId { get; set; } // Navigation property
    public required Address Address { get; set; } // Foreign Key to Address

    public ICollection<GameNight>? OrganizedGameNights { get; set; }
    public ICollection<Player>? PlaysIn { get; set; }
}
