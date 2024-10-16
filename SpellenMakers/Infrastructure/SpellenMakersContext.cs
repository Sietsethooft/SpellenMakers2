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
    public SpellenMakersContext(DbContextOptions<SpellenMakersContext> options)
            : base(options)
    {
    }

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

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configuratie voor GameNight_Games
        modelBuilder.Entity<GameNight_Games>()
            .HasKey(gn => new { gn.GameNightId, gn.GameId });

        // Configuratie voor GameNight_Snack
        modelBuilder.Entity<GameNight_Snack>()
            .HasKey(gs => new { gs.GameNightId, gs.SnackId });

        // Configuratie voor Player
        modelBuilder.Entity<Player>()
            .HasKey(p => new { p.UserId, p.GameNightId });

        // Configuratie voor foreign relaties


        modelBuilder.Entity<User>()
            .HasOne(u => u.Gender)
            .WithMany(g => g.Users)
            .HasForeignKey(u => u.GenderId)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<User>()
            .HasOne(u => u.Dietary)
            .WithMany()
            .HasForeignKey(u => u.DietaryId)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<User>()
            .HasOne(u => u.Address)
            .WithMany(a => a.Users)
            .HasForeignKey(u => u.AddressId)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<Address>()
            .HasOne(a => a.City)
            .WithMany(c => c.Addresses)
            .HasForeignKey(a => a.CityId)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<Player>()
            .HasOne(p => p.User)
            .WithMany(u => u.PlaysIn)
            .HasForeignKey(p => p.UserId);

        modelBuilder.Entity<Player>()
            .HasOne(p => p.GameNight)
            .WithMany(gn => gn.Players)
            .HasForeignKey(p => p.GameNightId)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<GameNight>()
            .HasOne(gn => gn.Organizer)
            .WithMany(u => u.OrganizedGameNights)
            .HasForeignKey(gn => gn.OrganizerId);

        modelBuilder.Entity<GameNight>()
            .HasOne(gn => gn.Address)
            .WithMany(a => a.GameNights)
            .HasForeignKey(gn => gn.AddressId)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<GameNight_Snack>()
            .HasOne(gs => gs.GameNight)
            .WithMany(gn => gn.Snacks)
            .HasForeignKey(gs => gs.GameNightId);

        modelBuilder.Entity<GameNight_Snack>()
            .HasOne(gs => gs.Snack)
            .WithMany(s => s.GameNight_Snacks)
            .HasForeignKey(gs => gs.SnackId);

        modelBuilder.Entity<GameNight_Games>()
            .HasOne(gg => gg.GameNight)
            .WithMany(gn => gn.Games)
            .HasForeignKey(gg => gg.GameNightId);

        modelBuilder.Entity<GameNight_Games>()
            .HasOne(gg => gg.Game)
            .WithMany(g => g.GameNight_Games)
            .HasForeignKey(gg => gg.GameId);

        modelBuilder.Entity<Game>()
            .HasOne(g => g.Genre)
            .WithMany(ge => ge.Games)
            .HasForeignKey(g => g.GenreId)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<Game>()
            .HasOne(g => g.Category)
            .WithMany(ce => ce.Games)
            .HasForeignKey(g => g.CategoryId)
            .OnDelete(DeleteBehavior.NoAction);

        base.OnModelCreating(modelBuilder);
    }
}