using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lezione8.Dev.Migrations
{
    /// <inheritdoc />
    public partial class GenresAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Genre",
                table: "Shelves");

            migrationBuilder.AddColumn<int>(
                name: "GenreId",
                table: "Shelves",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    GenreId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.GenreId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Shelves_GenreId",
                table: "Shelves",
                column: "GenreId");

            migrationBuilder.AddForeignKey(
                name: "FK_Shelves_Genres_GenreId",
                table: "Shelves",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "GenreId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shelves_Genres_GenreId",
                table: "Shelves");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropIndex(
                name: "IX_Shelves_GenreId",
                table: "Shelves");

            migrationBuilder.DropColumn(
                name: "GenreId",
                table: "Shelves");

            migrationBuilder.AddColumn<string>(
                name: "Genre",
                table: "Shelves",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
