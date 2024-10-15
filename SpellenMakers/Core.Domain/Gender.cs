namespace Core.Domain;

public class Gender
{
    public int GenderId { get; set; }
    public required string Name { get; set; }

    public ICollection<User>? Users { get; set; }
}
