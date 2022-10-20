using Microsoft.EntityFrameworkCore.Migrations;

namespace TrainingSystem.Data.Migrations
{
    public partial class AddedRolesToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2940df3d-3cc1-4447-9e19-c2e760de1e5c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d2e4e64c-aacf-4c2e-a971-2f741260891f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "113d69ed-6dfa-4897-bcfd-e3a6543f542c", "b62417a5-caeb-42f5-b6ca-5902fbae3e40", "Manager", "MANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4bb90f88-d3e1-40af-a190-ba8529871516", "3beb2950-f6b4-42af-9322-6ccf0ceae3e5", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "113d69ed-6dfa-4897-bcfd-e3a6543f542c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4bb90f88-d3e1-40af-a190-ba8529871516");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2940df3d-3cc1-4447-9e19-c2e760de1e5c", "44e3bafe-0e44-462b-99ae-0267477c6553", "Manager", "MANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d2e4e64c-aacf-4c2e-a971-2f741260891f", "24882f71-1299-44af-a40f-9dc2003cf6b0", "Administrator", "ADMINISTRATOR" });
        }
    }
}
