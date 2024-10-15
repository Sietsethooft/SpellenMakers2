using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain;

public class GameNight_Snack
{
    public int GameNightId { get; set; }
    public int SnackId { get; set; }

    public required GameNight GameNight { get; set; } // foreign key to GameNight
    public required Snack Snack { get; set; } // foreign key to Snack
}
