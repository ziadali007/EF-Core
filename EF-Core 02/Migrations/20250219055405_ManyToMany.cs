using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Core_02.Migrations
{
    /// <inheritdoc />
    public partial class ManyToMany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CourseStudent",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    Grade = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseStudent", x => new { x.StudentId, x.CourseId });
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CrsName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CourseStudentCourseId = table.Column<int>(type: "int", nullable: true),
                    CourseStudentStudentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Courses_CourseStudent_CourseStudentStudentId_CourseStudentCourseId",
                        columns: x => new { x.CourseStudentStudentId, x.CourseStudentCourseId },
                        principalTable: "CourseStudent",
                        principalColumns: new[] { "StudentId", "CourseId" });
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    CourseStudentCourseId = table.Column<int>(type: "int", nullable: true),
                    CourseStudentStudentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_CourseStudent_CourseStudentStudentId_CourseStudentCourseId",
                        columns: x => new { x.CourseStudentStudentId, x.CourseStudentCourseId },
                        principalTable: "CourseStudent",
                        principalColumns: new[] { "StudentId", "CourseId" });
                });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CourseStudentStudentId_CourseStudentCourseId",
                table: "Courses",
                columns: new[] { "CourseStudentStudentId", "CourseStudentCourseId" });

            migrationBuilder.CreateIndex(
                name: "IX_Students_CourseStudentStudentId_CourseStudentCourseId",
                table: "Students",
                columns: new[] { "CourseStudentStudentId", "CourseStudentCourseId" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "CourseStudent");
        }
    }
}
