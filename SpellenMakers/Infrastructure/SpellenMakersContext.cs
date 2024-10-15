using Core.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure;
public class SpellenMakersContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Address> Addresses { get; set; }
    public DbSet<City> Cities { get; set; }
    public DbSet<Dietary> Dietaries { get; set; }
    public DbSet<Game> Games { get; set; }
    public DbSet<GameNight> GameNights { get; set; }
    public DbSet<Player> Players { get; set; }
    public DbSet<GameNight_Snack> GameNight_Snacks { get; set; }
    public DbSet<GameNight_Games> GameNight_Games { get; set; }
    public DbSet<Snack> Snacks { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=spellenmakers;Trusted_Connection=True;");
    }
}