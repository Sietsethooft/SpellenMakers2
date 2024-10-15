using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain;

public class User
{
    public int UserId { get; set; }
    public required string Name { get; set; }
    public required string Email { get; set; }
    public DateTime Birthday { get; set; }

    public GenderEnum GenderId { get; set; } // Foreign Key to GenderEnum
    public required Dietary DietaryId { get; set; } // Foreign Key to Dietary
    public required Address AddressId { get; set; } // Foreign Key to Address

    public ICollection<GameNight>? OrganizedGameNights { get; set; }
    public ICollection<Player>? PlaysIn { get; set; }
}
