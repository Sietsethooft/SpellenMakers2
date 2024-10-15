namespace Core.Domain;

public class Address
{
    public int AddressId { get; set; }
    public required string HouseNumber { get; set; }
    public required string Street { get; set; }

    public int CityId { get; set; } // Navigation property
    public required City City { get; set; } // Foreign Key to City

    public ICollection<User>? Users { get; set; }
    public ICollection<GameNight>? GameNights { get; set; }
}