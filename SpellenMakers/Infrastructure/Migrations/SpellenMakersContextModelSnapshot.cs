﻿// <auto-generated />
using System;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(SpellenMakersContext))]
    partial class SpellenMakersContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Core.Domain.Address", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AddressId"));

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("HouseNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AddressId");

                    b.HasIndex("CityId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("Core.Domain.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("Core.Domain.City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CityId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CityId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("Core.Domain.Dietary", b =>
                {
                    b.Property<int>("DietaryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DietaryId"));

                    b.Property<bool>("HasLactose")
                        .HasColumnType("bit");

                    b.Property<bool>("HasNutAllergy")
                        .HasColumnType("bit");

                    b.Property<bool>("WantsAlcohol")
                        .HasColumnType("bit");

                    b.Property<bool>("isVegetarian")
                        .HasColumnType("bit");

                    b.HasKey("DietaryId");

                    b.ToTable("Dietaries");
                });

            modelBuilder.Entity("Core.Domain.Game", b =>
                {
                    b.Property<int>("GameId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GameId"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("GameDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<bool>("Is18Plus")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Picture")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.HasKey("GameId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("GenreId");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("Core.Domain.GameNight", b =>
                {
                    b.Property<int>("GameNightId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GameNightId"));

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<bool>("BringSnacks")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Is18Plus")
                        .HasColumnType("bit");

                    b.Property<int>("MaxCountPlayers")
                        .HasColumnType("int");

                    b.Property<int>("OrganizerId")
                        .HasColumnType("int");

                    b.Property<TimeOnly>("Time")
                        .HasColumnType("time");

                    b.HasKey("GameNightId");

                    b.HasIndex("AddressId");

                    b.HasIndex("OrganizerId");

                    b.ToTable("GameNights");
                });

            modelBuilder.Entity("Core.Domain.GameNight_Games", b =>
                {
                    b.Property<int>("GameNightId")
                        .HasColumnType("int");

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.HasKey("GameNightId", "GameId");

                    b.HasIndex("GameId");

                    b.ToTable("GameNight_Games");
                });

            modelBuilder.Entity("Core.Domain.GameNight_Snack", b =>
                {
                    b.Property<int>("GameNightId")
                        .HasColumnType("int");

                    b.Property<int>("SnackId")
                        .HasColumnType("int");

                    b.HasKey("GameNightId", "SnackId");

                    b.HasIndex("SnackId");

                    b.ToTable("GameNight_Snacks");
                });

            modelBuilder.Entity("Core.Domain.Gender", b =>
                {
                    b.Property<int>("GenderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GenderId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GenderId");

                    b.ToTable("Gender");
                });

            modelBuilder.Entity("Core.Domain.Genre", b =>
                {
                    b.Property<int>("GenreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GenreId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GenreId");

                    b.ToTable("Genre");
                });

            modelBuilder.Entity("Core.Domain.Player", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("GameNightId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "GameNightId");

                    b.HasIndex("GameNightId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("Core.Domain.Snack", b =>
                {
                    b.Property<int>("SnackId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SnackId"));

                    b.Property<bool>("HasAlcohol")
                        .HasColumnType("bit");

                    b.Property<bool>("HasLactose")
                        .HasColumnType("bit");

                    b.Property<bool>("HasNuts")
                        .HasColumnType("bit");

                    b.Property<bool>("IsVegetarian")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SnackId");

                    b.ToTable("Snacks");
                });

            modelBuilder.Entity("Core.Domain.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<int>("DietaryId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GenderId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.HasIndex("AddressId");

                    b.HasIndex("DietaryId");

                    b.HasIndex("GenderId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Core.Domain.Address", b =>
                {
                    b.HasOne("Core.Domain.City", "City")
                        .WithMany("Addresses")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("Core.Domain.Game", b =>
                {
                    b.HasOne("Core.Domain.Category", "Category")
                        .WithMany("Games")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Core.Domain.Genre", "Genre")
                        .WithMany("Games")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("Core.Domain.GameNight", b =>
                {
                    b.HasOne("Core.Domain.Address", "Address")
                        .WithMany("GameNights")
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Core.Domain.User", "Organizer")
                        .WithMany("OrganizedGameNights")
                        .HasForeignKey("OrganizerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");

                    b.Navigation("Organizer");
                });

            modelBuilder.Entity("Core.Domain.GameNight_Games", b =>
                {
                    b.HasOne("Core.Domain.Game", "Game")
                        .WithMany("GameNight_Games")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Domain.GameNight", "GameNight")
                        .WithMany("Games")
                        .HasForeignKey("GameNightId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");

                    b.Navigation("GameNight");
                });

            modelBuilder.Entity("Core.Domain.GameNight_Snack", b =>
                {
                    b.HasOne("Core.Domain.GameNight", "GameNight")
                        .WithMany("Snacks")
                        .HasForeignKey("GameNightId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Domain.Snack", "Snack")
                        .WithMany("GameNight_Snacks")
                        .HasForeignKey("SnackId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GameNight");

                    b.Navigation("Snack");
                });

            modelBuilder.Entity("Core.Domain.Player", b =>
                {
                    b.HasOne("Core.Domain.GameNight", "GameNight")
                        .WithMany("Players")
                        .HasForeignKey("GameNightId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Core.Domain.User", "User")
                        .WithMany("PlaysIn")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GameNight");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Core.Domain.User", b =>
                {
                    b.HasOne("Core.Domain.Address", "Address")
                        .WithMany("Users")
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Core.Domain.Dietary", "Dietary")
                        .WithMany()
                        .HasForeignKey("DietaryId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Core.Domain.Gender", "Gender")
                        .WithMany("Users")
                        .HasForeignKey("GenderId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Address");

                    b.Navigation("Dietary");

                    b.Navigation("Gender");
                });

            modelBuilder.Entity("Core.Domain.Address", b =>
                {
                    b.Navigation("GameNights");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Core.Domain.Category", b =>
                {
                    b.Navigation("Games");
                });

            modelBuilder.Entity("Core.Domain.City", b =>
                {
                    b.Navigation("Addresses");
                });

            modelBuilder.Entity("Core.Domain.Game", b =>
                {
                    b.Navigation("GameNight_Games");
                });

            modelBuilder.Entity("Core.Domain.GameNight", b =>
                {
                    b.Navigation("Games");

                    b.Navigation("Players");

                    b.Navigation("Snacks");
                });

            modelBuilder.Entity("Core.Domain.Gender", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("Core.Domain.Genre", b =>
                {
                    b.Navigation("Games");
                });

            modelBuilder.Entity("Core.Domain.Snack", b =>
                {
                    b.Navigation("GameNight_Snacks");
                });

            modelBuilder.Entity("Core.Domain.User", b =>
                {
                    b.Navigation("OrganizedGameNights");

                    b.Navigation("PlaysIn");
                });
#pragma warning restore 612, 618
        }
    }
}
