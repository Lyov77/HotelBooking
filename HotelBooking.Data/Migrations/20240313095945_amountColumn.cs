using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelBooking.Data.Migrations
{
    /// <inheritdoc />
    public partial class amountColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                column: "StartDate",
                value: new DateTime(2024, 3, 13, 13, 59, 44, 898, DateTimeKind.Local).AddTicks(8363));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                column: "StartDate",
                value: new DateTime(2024, 3, 13, 13, 41, 38, 854, DateTimeKind.Local).AddTicks(9487));
        }
    }
}
