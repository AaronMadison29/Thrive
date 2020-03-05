using Microsoft.EntityFrameworkCore.Migrations;

namespace ThriveAPP.Data.Migrations
{
    public partial class UserRolls : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1b7156cb-dce8-4aae-a962-b4f0a124182d", "34cb8508-cc36-4ba0-b194-103e8b0234e1", "Teacher", "TEACHER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "de5711bd-2e5d-4587-9ce2-b855840d7e7e", "2c55346a-95d6-440d-8f48-fa4c3e2de83c", "Student", "STUDENT" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1b7156cb-dce8-4aae-a962-b4f0a124182d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "de5711bd-2e5d-4587-9ce2-b855840d7e7e");
        }
    }
}
