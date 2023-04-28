using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cinema.Data.Migrations
{
    public partial class Payment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetail_Movie_MovieID",
                table: "OrderDetail");

            migrationBuilder.DropTable(
                name: "CinemaCartItem");

            migrationBuilder.DropTable(
                name: "Reservation");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetail_MovieID",
                table: "OrderDetail");

            migrationBuilder.DropColumn(
                name: "MovieID",
                table: "OrderDetail");

            migrationBuilder.DropColumn(
                name: "price",
                table: "OrderDetail");

            migrationBuilder.AddColumn<string>(
                name: "hours",
                table: "OrderDetail",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "people",
                table: "OrderDetail",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "people",
                table: "Order",
                maxLength: 1,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 1);

            migrationBuilder.AlterColumn<string>(
                name: "hours",
                table: "Order",
                maxLength: 1,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "hours",
                table: "OrderDetail");

            migrationBuilder.DropColumn(
                name: "people",
                table: "OrderDetail");

            migrationBuilder.AddColumn<int>(
                name: "MovieID",
                table: "OrderDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<long>(
                name: "price",
                table: "OrderDetail",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AlterColumn<int>(
                name: "people",
                table: "Order",
                type: "int",
                maxLength: 1,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 1);

            migrationBuilder.AlterColumn<int>(
                name: "hours",
                table: "Order",
                type: "int",
                maxLength: 1,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 1);

            migrationBuilder.CreateTable(
                name: "CinemaCartItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CinemaCartId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    movieid = table.Column<int>(type: "int", nullable: true),
                    price = table.Column<int>(type: "int", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "Reservation",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReservationId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    data = table.Column<int>(type: "int", nullable: false),
                    day = table.Column<DateTime>(type: "datetime2", nullable: false),
                    hour = table.Column<DateTime>(type: "datetime2", nullable: false),
                    minute = table.Column<DateTime>(type: "datetime2", nullable: false),
                    month = table.Column<DateTime>(type: "datetime2", nullable: false),
                    people = table.Column<int>(type: "int", nullable: false),
                    rentedHours = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservation", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_MovieID",
                table: "OrderDetail",
                column: "MovieID");

            migrationBuilder.CreateIndex(
                name: "IX_CinemaCartItem_movieid",
                table: "CinemaCartItem",
                column: "movieid");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetail_Movie_MovieID",
                table: "OrderDetail",
                column: "MovieID",
                principalTable: "Movie",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
