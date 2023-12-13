using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScoreManagement.Migrations
{
    /// <inheritdoc />
    public partial class migration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ClassSubjects",
                columns: new[] { "ClassSubjectID", "ClassName", "SubjectID" },
                values: new object[] { "501", "LTW01", 5 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClassSubjects",
                keyColumn: "ClassSubjectID",
                keyValue: "501");
        }
    }
}
