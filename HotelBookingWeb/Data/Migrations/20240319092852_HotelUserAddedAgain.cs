using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelBookingWeb.Data.Migrations
{
    /// <inheritdoc />
    public partial class HotelUserAddedAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "description",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ordersCount",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "description",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ordersCount",
                table: "AspNetUsers");
        }
    }
}
