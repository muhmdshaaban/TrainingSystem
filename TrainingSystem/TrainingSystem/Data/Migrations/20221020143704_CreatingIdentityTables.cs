using Microsoft.EntityFrameworkCore.Migrations;

namespace TrainingSystem.Data.Migrations
{
    public partial class CreatingIdentityTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "2940df3d-3cc1-4447-9e19-c2e760de1e5c", "44e3bafe-0e44-462b-99ae-0267477c6553", "Manager", "MANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d2e4e64c-aacf-4c2e-a971-2f741260891f", "24882f71-1299-44af-a40f-9dc2003cf6b0", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "c5b012cf-41b4-464a-83db-436411d3615a", "a700b2a9-8546-4a54-811d-04a1c787fc41", "Manager", "MANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "72f812d8-19e1-4dc1-9e27-1c750a59afb2", "85127469-efc6-472c-9ec0-f79edd9a3071", "Administrator", "ADMINISTRATOR" });
        }
    }
}
