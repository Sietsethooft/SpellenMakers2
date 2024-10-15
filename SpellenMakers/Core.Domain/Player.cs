using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain;

public class Player
{
    public int UserId { get; set; }
    public int GameNightId { get; set; }
    
    public required User User { get; set; } // foreign key to User
    public required GameNight GameNight { get; set; } // foreign key to GameNight
}
