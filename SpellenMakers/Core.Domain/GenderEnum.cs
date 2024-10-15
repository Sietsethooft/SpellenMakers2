using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain;

public class GenderEnum
{
    public int GenderId { get; set; }
    public required string Gender { get; set; }

    public ICollection<User>? Users { get; set; }
}
