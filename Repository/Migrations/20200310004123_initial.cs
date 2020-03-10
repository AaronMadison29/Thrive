using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    ClassId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Subject = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.ClassId);
                });

            migrationBuilder.CreateTable(
                name: "Profiles",
                columns: table => new
                {
                    ProfileId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FavoriteSubject = table.Column<string>(type: "varchar(25)", nullable: true),
                    LearningStyle = table.Column<string>(type: "varchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profiles", x => x.ProfileId);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    TeacherId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: false),
                    Subject = table.Column<string>(type: "varchar(25)", nullable: false),
                    ClassId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.TeacherId);
                    table.ForeignKey(
                        name: "FK_Teachers_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "ClassId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Notes",
                columns: table => new
                {
                    NoteId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(maxLength: 2000, nullable: false),
                    profileId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notes", x => x.NoteId);
                    table.ForeignKey(
                        name: "FK_Notes_Profiles_profileId",
                        column: x => x.profileId,
                        principalTable: "Profiles",
                        principalColumn: "ProfileId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    Name = table.Column<string>(type: "varchar(75)", nullable: false),
                    Email = table.Column<string>(nullable: true),
                    ProfileId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                    table.ForeignKey(
                        name: "FK_Students_Profiles_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "Profiles",
                        principalColumn: "ProfileId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Parents",
                columns: table => new
                {
                    ParentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(maxLength: 100, nullable: true),
                    StudentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parents", x => x.ParentId);
                    table.ForeignKey(
                        name: "FK_Parents_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentClassGrades",
                columns: table => new
                {
                    StudentClassGradeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<int>(nullable: false),
                    ClassId = table.Column<int>(nullable: false),
                    Grade = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentClassGrades", x => x.StudentClassGradeId);
                    table.ForeignKey(
                        name: "FK_StudentClassGrades_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "ClassId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentClassGrades_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "ClassId", "Subject" },
                values: new object[,]
                {
                    { 1, "Math" },
                    { 2, "Science" },
                    { 3, "History" }
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
                    { 3, null, "Steve Melton", 3, null },
                    { 5, null, "Jeff Sather", 5, null },
                    { 7, null, "Samuel Martinez", 7, null },
                    { 4, null, "Bill Johnson", 4, null },
                    { 8, null, "Frank Madison", 8, null },
                    { 9, null, "Max Collins", 9, null },
                    { 2, null, "Kim Clennan", 2, null },
                    { 6, null, "Amy Sanchez", 6, null },
                    { 1, null, "Kelly Madison", 1, null },
                    { 10, null, "Bob Vogg", 10, null }
                });

            migrationBuilder.InsertData(
                table: "StudentClassGrades",
                columns: new[] { "StudentClassGradeId", "ClassId", "Grade", "StudentId" },
                values: new object[,]
                {
                    { 26, 2, 100, 9 },
                    { 24, 3, 100, 8 },
                    { 23, 2, 100, 8 },
                    { 16, 1, 100, 6 },
                    { 22, 1, 100, 8 },
                    { 27, 3, 100, 9 },
                    { 21, 3, 100, 7 },
                    { 20, 2, 100, 7 },
                    { 19, 1, 100, 7 },
                    { 28, 1, 100, 10 },
                    { 18, 3, 100, 6 },
                    { 17, 2, 100, 6 },
                    { 25, 1, 100, 9 },
                    { 14, 2, 100, 5 },
                    { 30, 3, 100, 10 },
                    { 29, 2, 100, 10 },
                    { 1, 1, 100, 1 },
                    { 2, 2, 100, 1 },
                    { 3, 3, 100, 1 },
                    { 4, 1, 100, 2 },
                    { 5, 2, 100, 2 },
                    { 15, 3, 100, 5 },
                    { 6, 3, 100, 2 },
                    { 8, 2, 100, 3 },
                    { 9, 3, 100, 3 },
                    { 10, 1, 100, 4 },
                    { 11, 2, 100, 4 },
                    { 12, 3, 100, 4 },
                    { 13, 1, 100, 5 },
                    { 7, 1, 100, 3 }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "TeacherId", "ClassId", "Email", "Name", "PhoneNumber", "Subject", "UserId" },
                values: new object[,]
                {
                    { 3, 3, null, "David Lagrange", "555-555-5555", "History", null },
                    { 2, 2, null, "Nevin Seibel", "222-222-2222", "Science", null },
                    { 1, 1, null, "Mike Terrill", "111-111-1111", "Math", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Notes_profileId",
                table: "Notes",
                column: "profileId");

            migrationBuilder.CreateIndex(
                name: "IX_Parents_StudentId",
                table: "Parents",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentClassGrades_ClassId",
                table: "StudentClassGrades",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentClassGrades_StudentId",
                table: "StudentClassGrades",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_ProfileId",
                table: "Students",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_ClassId",
                table: "Teachers",
                column: "ClassId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notes");

            migrationBuilder.DropTable(
                name: "Parents");

            migrationBuilder.DropTable(
                name: "StudentClassGrades");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "Profiles");
        }
    }
}
