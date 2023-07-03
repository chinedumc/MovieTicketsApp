using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieTicketsApp.Migrations
{
    /// <inheritdoc />
    public partial class ActorMovie : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Actors_Movies_ActorId",
                table: "Actors_Movies");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Actors_Movies_ActorId",
                table: "Actors_Movies",
                column: "ActorId",
                unique: true);
        }
    }
}
