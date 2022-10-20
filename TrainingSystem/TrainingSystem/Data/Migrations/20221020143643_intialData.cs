using Microsoft.EntityFrameworkCore.Migrations;

namespace TrainingSystem.Data.Migrations
{
    public partial class intialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c070a7e8-968f-43e6-906d-afe12e6b75dc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fceef8c8-9ec9-436d-a5c7-ed424e082142");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c5b012cf-41b4-464a-83db-436411d3615a", "a700b2a9-8546-4a54-811d-04a1c787fc41", "Manager", "MANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "72f812d8-19e1-4dc1-9e27-1c750a59afb2", "85127469-efc6-472c-9ec0-f79edd9a3071", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "72f812d8-19e1-4dc1-9e27-1c750a59afb2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c5b012cf-41b4-464a-83db-436411d3615a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fceef8c8-9ec9-436d-a5c7-ed424e082142", "11bbfd9f-a395-4470-b5db-3157e4cbae42", "Manager", "MANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c070a7e8-968f-43e6-906d-afe12e6b75dc", "11bfc5ca-edcc-4c66-98b3-50d4a74d26e0", "Administrator", "ADMINISTRATOR" });
        }
    }
}
