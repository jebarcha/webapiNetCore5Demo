using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelListing2.Migrations
{
    public partial class AddedIdentityRoles2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "47fe80a6-0bf9-43f2-b9b5-74167963c3fb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "529da502-84a9-4b1e-bb67-b94ca3de229e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c49e94ec-e2bf-4946-aed2-b8c801edf164", "4656f55b-1152-40a3-b8c3-df77c483b2a7", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3f226a02-43aa-4452-9161-02c82fcbe951", "1cf95d02-2db5-4562-9768-868a924dbc2f", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3f226a02-43aa-4452-9161-02c82fcbe951");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c49e94ec-e2bf-4946-aed2-b8c801edf164");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "47fe80a6-0bf9-43f2-b9b5-74167963c3fb", "8fda3f18-e311-4e8d-8c73-7899dbf7e5da", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "529da502-84a9-4b1e-bb67-b94ca3de229e", "0f52c739-0489-41f1-a074-45e4278debb5", "Administrator", "ADMINISTRATOR" });
        }
    }
}
