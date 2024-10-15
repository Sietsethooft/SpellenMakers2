namespace Core.Domain;

public class City
{
    public int CityId { get; set; }
    public required string Name { get; set; }

    public ICollection<Address>? Addresses { get; set; }
}