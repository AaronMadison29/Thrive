using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class seededProfiles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "ProfileId", "FavoriteSubject", "LearningStyle", "Notes" },
                values: new object[,]
                {
                    { 1, null, null, null },
                    { 2, null, null, null },
                    { 3, null, null, null },
                    { 4, null, null, null },
                    { 5, null, null, null },
                    { 6, null, null, null },
                    { 7, null, null, null },
                    { 8, null, null, null },
                    { 9, null, null, null },
                    { 10, null, null, null }
                });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1,
                column: "ProfileId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2,
                column: "ProfileId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 3,
                column: "ProfileId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 4,
                column: "ProfileId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 5,
                column: "ProfileId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 6,
                column: "ProfileId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 7,
                column: "ProfileId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 8,
                column: "ProfileId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 9,
                column: "ProfileId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 10,
                column: "ProfileId",
                value: 10);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Profiles",
                keyColumn: "ProfileId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Profiles",
                keyColumn: "ProfileId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Profiles",
                keyColumn: "ProfileId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Profiles",
                keyColumn: "ProfileId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Profiles",
                keyColumn: "ProfileId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Profiles",
                keyColumn: "ProfileId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Profiles",
                keyColumn: "ProfileId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Profiles",
                keyColumn: "ProfileId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Profiles",
                keyColumn: "ProfileId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Profiles",
                keyColumn: "ProfileId",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1,
                column: "ProfileId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2,
                column: "ProfileId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 3,
                column: "ProfileId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 4,
                column: "ProfileId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 5,
                column: "ProfileId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 6,
                column: "ProfileId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 7,
                column: "ProfileId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 8,
                column: "ProfileId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 9,
                column: "ProfileId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 10,
                column: "ProfileId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1,
                column: "ProfileId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2,
                column: "ProfileId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 3,
                column: "ProfileId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 4,
                column: "ProfileId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 5,
                column: "ProfileId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 6,
                column: "ProfileId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 7,
                column: "ProfileId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 8,
                column: "ProfileId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 9,
                column: "ProfileId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 10,
                column: "ProfileId",
                value: null);
        }
    }
}
