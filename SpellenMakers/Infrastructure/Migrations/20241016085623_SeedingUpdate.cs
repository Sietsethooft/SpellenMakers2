using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedingUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { 1, "Bordspel" },
                    { 2, "Kaartspel" },
                    { 3, "Dobbelspel" },
                    { 4, "Partyspel" },
                    { 5, "Puzezelspel" }
                });

            migrationBuilder.InsertData(
                table: "Gender",
                columns: new[] { "GenderId", "Name" },
                values: new object[,]
                {
                    { 1, "M" },
                    { 2, "V" },
                    { 3, "X" }
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "GenreId", "Name" },
                values: new object[,]
                {
                    { 1, "Strategie" },
                    { 2, "Party" },
                    { 3, "Familie" },
                    { 4, "Coöperatief" },
                    { 5, "Detective" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Gender",
                keyColumn: "GenderId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Gender",
                keyColumn: "GenderId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Gender",
                keyColumn: "GenderId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "GenreId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "GenreId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "GenreId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "GenreId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "GenreId",
                keyValue: 5);
        }
    }
}
