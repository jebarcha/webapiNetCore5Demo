using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelListing2.Migrations
{
    public partial class AddedIdentityRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "47fe80a6-0bf9-43f2-b9b5-74167963c3fb", "8fda3f18-e311-4e8d-8c73-7899dbf7e5da", "User", "USER" },
                    { "529da502-84a9-4b1e-bb67-b94ca3de229e", "0f52c739-0489-41f1-a074-45e4278debb5", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "CountryId", "Name", "Rating" },
                values: new object[] { "George Town", 3, "Comfort Suites", 4.2999999999999998 });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "CountryId", "Name", "Rating" },
                values: new object[] { "Nassua", 2, "Grand Palldium", 4.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "47fe80a6-0bf9-43f2-b9b5-74167963c3fb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "529da502-84a9-4b1e-bb67-b94ca3de229e");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "CountryId", "Name", "Rating" },
                values: new object[] { "Nassua", 2, "Grand Paladium", 4.0 });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "CountryId", "Name", "Rating" },
                values: new object[] { "George Town", 3, "Confort Suites", 4.2999999999999998 });
        }
    }
}
