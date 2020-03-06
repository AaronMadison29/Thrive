using Microsoft.EntityFrameworkCore.Migrations;

namespace ThriveAPP.Data.Migrations
{
    public partial class ParentUserRoleAdded : Migration
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
                values: new object[] { "fa658bf1-0aff-4354-bf0e-d1d0fd7145a1", "92c39589-cbd4-4578-a77d-a87b80772690", "Teacher", "TEACHER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b49707bb-e7c2-45cb-ab1f-0dac76044144", "dccc9ff0-818e-4e49-8619-f1108dd1a728", "Student", "STUDENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0a336db9-01ce-46ce-b26e-2bd75459e662", "2f00a93e-9832-4103-bf84-8ce4558fe06f", "Parent", "PARENT" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0a336db9-01ce-46ce-b26e-2bd75459e662");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b49707bb-e7c2-45cb-ab1f-0dac76044144");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa658bf1-0aff-4354-bf0e-d1d0fd7145a1");

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
