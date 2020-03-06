using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class removeParentEmailFromStudent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ParentEmail",
                table: "Students");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ParentEmail",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
