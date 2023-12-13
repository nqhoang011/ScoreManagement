using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScoreManagement.Migrations
{
    /// <inheritdoc />
    public partial class migration4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ClassSubjects",
                columns: new[] { "ClassSubjectID", "ClassName", "SubjectID" },
                values: new object[] { "502", "LTW02", 5 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClassSubjects",
                keyColumn: "ClassSubjectID",
                keyValue: "502");
        }
    }
}
