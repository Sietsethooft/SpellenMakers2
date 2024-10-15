using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain;

public class Game
{
    [Key]
    public required string GameName { get; set; }
    public required string GameDescription { get; set; }
    public bool Is18Plus { get; set; }
    public required byte[] Picture { get; set; }

    public GenreEnum GenreId { get; set; } // Foreign Key to GenreEnum
    public CategoryEnum CategoryId { get; set; } // Foreign Key to CategoryEnum

    public ICollection<GameNight_Games>? GameNight_Games { get; set; }
}
