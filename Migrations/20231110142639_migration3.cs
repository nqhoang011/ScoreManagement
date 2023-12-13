using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ScoreManagement.Migrations
{
    /// <inheritdoc />
    public partial class migration3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ClassSubjects",
                columns: new[] { "ClassSubjectID", "ClassName", "SubjectID" },
                values: new object[,]
                {
                    { "301", "QTNL01", 7 },
                    { "401", "NPVCP01", 8 },
                    { "601", "DTCB01", 6 }
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "SubjectID", "FacultyID", "SubjectName" },
                values: new object[,]
                {
                    { 6L, "DTVT", "Điện tử cơ bản" },
                    { 7L, "QTKD", "Quản trị nhân lực" },
                    { 8L, "NNA", "Ngữ pháp và cú pháp" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClassSubjects",
                keyColumn: "ClassSubjectID",
                keyValue: "301");

            migrationBuilder.DeleteData(
                table: "ClassSubjects",
                keyColumn: "ClassSubjectID",
                keyValue: "401");

            migrationBuilder.DeleteData(
                table: "ClassSubjects",
                keyColumn: "ClassSubjectID",
                keyValue: "601");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectID",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectID",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectID",
                keyValue: 8L);
        }
    }
}
