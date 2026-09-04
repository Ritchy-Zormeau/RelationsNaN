using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RelationsNaN.Migrations
{
    /// <inheritdoc />
    public partial class relationGameGenre : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GenreId",
                table: "Game",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Game_GenreId",
                table: "Game",
                column: "GenreId");

            migrationBuilder.AddForeignKey(
                name: "FK_Game_Genre_GenreId",
                table: "Game",
                column: "GenreId",
                principalTable: "Genre",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Game_Genre_GenreId",
                table: "Game");

            migrationBuilder.DropIndex(
                name: "IX_Game_GenreId",
                table: "Game");

            migrationBuilder.DropColumn(
                name: "GenreId",
                table: "Game");
        }
    }
}
