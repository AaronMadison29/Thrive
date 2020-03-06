using Microsoft.EntityFrameworkCore.Migrations;

namespace ThriveAPP.Data.Migrations
{
    public partial class addParentToSeedRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "75afc49e-9727-4a41-90cf-bafe8efbd311");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ab9ae231-3c85-42c0-8104-a5c02ac2cfb3");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a6cf2762-67c8-4272-88b0-aaa9228c2290", "ebe02120-ba69-48d9-b27c-cb0325d0948a", "Teacher", "TEACHER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8695c97b-8d23-4d59-93fa-35ee049a2998", "4edbf6fc-4dbf-4881-ad29-2b7fc0c6e2b8", "Parent", "PARENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "85fe2ff4-2048-481d-a36a-b870ee7a5ef1", "5171dedc-46a1-4443-8713-4de77ee195b5", "Student", "STUDENT" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "85fe2ff4-2048-481d-a36a-b870ee7a5ef1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8695c97b-8d23-4d59-93fa-35ee049a2998");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a6cf2762-67c8-4272-88b0-aaa9228c2290");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ab9ae231-3c85-42c0-8104-a5c02ac2cfb3", "8a9d6904-ed6f-4ad6-937f-1c3ebdc111ee", "Teacher", "TEACHER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "75afc49e-9727-4a41-90cf-bafe8efbd311", "a579cf2c-8637-47de-8c5c-c2f1be6cf2d5", "Student", "STUDENT" });
        }
    }
}
