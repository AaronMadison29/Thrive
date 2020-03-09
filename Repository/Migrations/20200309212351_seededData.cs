using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class seededData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classes_Teachers_TeacherId",
                table: "Classes");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Parents_ParentId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_ParentId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Classes_TeacherId",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "TeacherId",
                table: "Classes");

            migrationBuilder.AddColumn<int>(
                name: "ClassId",
                table: "Teachers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "Parents",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "ClassId", "StudentId", "Subject" },
                values: new object[,]
                {
                    { 1, null, "Math" },
                    { 2, null, "Science" },
                    { 3, null, "History" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "Email", "Name", "ProfileId", "UserId" },
                values: new object[,]
                {
                    { 1, null, "Aaron Madison", null, null },
                    { 2, null, "Sean Clennan", null, null },
                    { 3, null, "Zac Melton", null, null },
                    { 4, null, "Marcus Johnson", null, null },
                    { 5, null, "Charlie Sather", null, null },
                    { 6, null, "Abraham Sanchez", null, null },
                    { 7, null, "Jacob Martinez", null, null },
                    { 8, null, "Billy Madison", null, null },
                    { 9, null, "Phil Collins", null, null },
                    { 10, null, "Parker Vogg", null, null }
                });

            migrationBuilder.InsertData(
                table: "Parents",
                columns: new[] { "ParentId", "Email", "Name", "StudentId", "UserId" },
                values: new object[,]
                {
                    { 1, null, "Kelly Madison", 1, null },
                    { 2, null, "Kim Clennan", 2, null },
                    { 3, null, "Steve Melton", 3, null },
                    { 4, null, "Bill Johnson", 4, null },
                    { 5, null, "Jeff Sather", 5, null },
                    { 6, null, "Amy Sanchez", 6, null },
                    { 7, null, "Samuel Martinez", 7, null },
                    { 8, null, "Frank Madison", 8, null },
                    { 9, null, "Max Collins", 9, null },
                    { 10, null, "Bob Vogg", 10, null }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "TeacherId", "ClassId", "Email", "Name", "PhoneNumber", "Subject", "UserId" },
                values: new object[,]
                {
                    { 1, 1, null, "Mike Terrill", "111-111-1111", "Math", null },
                    { 2, 2, null, "Nevin Seibel", "222-222-2222", "Science", null },
                    { 3, 3, null, "David Lagrange", "555-555-5555", "History", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_ClassId",
                table: "Teachers",
                column: "ClassId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Parents_StudentId",
                table: "Parents",
                column: "StudentId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Parents_Students_StudentId",
                table: "Parents",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_Classes_ClassId",
                table: "Teachers",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "ClassId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Parents_Students_StudentId",
                table: "Parents");

            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_Classes_ClassId",
                table: "Teachers");

            migrationBuilder.DropIndex(
                name: "IX_Teachers_ClassId",
                table: "Teachers");

            migrationBuilder.DropIndex(
                name: "IX_Parents_StudentId",
                table: "Parents");

            migrationBuilder.DeleteData(
                table: "Parents",
                keyColumn: "ParentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Parents",
                keyColumn: "ParentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Parents",
                keyColumn: "ParentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Parents",
                keyColumn: "ParentId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Parents",
                keyColumn: "ParentId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Parents",
                keyColumn: "ParentId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Parents",
                keyColumn: "ParentId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Parents",
                keyColumn: "ParentId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Parents",
                keyColumn: "ParentId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Parents",
                keyColumn: "ParentId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "ClassId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 10);

            migrationBuilder.DropColumn(
                name: "ClassId",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Parents");

            migrationBuilder.AddColumn<int>(
                name: "ParentId",
                table: "Students",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TeacherId",
                table: "Classes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Students_ParentId",
                table: "Students",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_TeacherId",
                table: "Classes",
                column: "TeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_Teachers_TeacherId",
                table: "Classes",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "TeacherId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Parents_ParentId",
                table: "Students",
                column: "ParentId",
                principalTable: "Parents",
                principalColumn: "ParentId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
