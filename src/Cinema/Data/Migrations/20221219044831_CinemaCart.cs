using Microsoft.EntityFrameworkCore.Migrations;

namespace Cinema.Data.Migrations
{
    public partial class CinemaCart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CinemaCartItem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    movieid = table.Column<int>(nullable: true),
                    price = table.Column<int>(nullable: false),
                    CinemaCartId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CinemaCartItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CinemaCartItem_Movie_movieid",
                        column: x => x.movieid,
                        principalTable: "Movie",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CinemaCartItem_movieid",
                table: "CinemaCartItem",
                column: "movieid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CinemaCartItem");
        }
    }
}
