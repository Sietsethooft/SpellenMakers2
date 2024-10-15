namespace Core.Domain;

public class Address
{
    public int AddressId { get; set; }
    public required string HouseNumber { get; set; }
    public required string Street { get; set; }
    public required City CityId { get; set; } // Foreign Key to City
    public ICollection<User>? Users { get; set; }
}